using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Xml;
using System.Xml.Schema;

namespace SVSXML
{
    public partial class Main : Form
    {
        //Excel
        private Excel.Workbook MyBook = null;
        private Excel.Application MyApp = null;
        private Excel.Worksheet MySheet = null;

        //Lista de fondos de inversión privada
        private List<Fip> fipList;

        public Main()
        {
            InitializeComponent();

            //Inicializa la variable
            fipList = new List<Fip>();
        }

        //Obtiene el archivo y comienza a procesarlo
        private void procesarBtn_Click(object sender, EventArgs e)
        {
            //Crea el documento
            XmlDocument doc = new XmlDocument();
            //Crea la raiz y le da formato
            XmlElement rootElement = (XmlElement)doc.AppendChild(doc.CreateElement("informacionAFIP"));
            rootElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");

            //Agrega el periodo de información
            DateTime dt = Convert.ToDateTime(dateText.Text);
            rootElement.AppendChild(doc.CreateElement("periodoInformacion")).InnerText = dt.ToString("yyyyMMdd");

            //Agrega el rut y dígito de la entidad
            rootElement.AppendChild(doc.CreateElement("rutEntidad")).InnerText = rutText.Text;
            rootElement.AppendChild(doc.CreateElement("digitoEntidad")).InnerText = dvText.Text;

            //Agrega los fondos como elemento
            XmlElement fondosRootElement = (XmlElement)rootElement.AppendChild(doc.CreateElement("fondos"));

            //Procesa el archivo Excel para
            //1) Crear los fondos de inversión privados
            //2) Agregar aportantes a esos fondos
            this.MyApp = new Excel.Application();
            this.MyApp.Visible = false;
            this.MyBook = MyApp.Workbooks.Open(archivoText.Text);
            this.MySheet = (Excel.Worksheet)MyBook.Sheets[1];

            int lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            
            //El primer proceso es para crear un list con los fondos de inversión privada
            for (int index = 2; index <= lastRow - 1; index++)
            {
                //Obtiene la fila
                System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "R" + index.ToString()).Cells.Value;

                //Obtiene los datos del Excel
                string fipRut = MyValues.GetValue(1, 4).ToString();
                string digitoFondo = MyValues.GetValue(1, 5).ToString();
                string denominacionFondo = MyValues.GetValue(1, 6).ToString();
                string valorActivos = MyValues.GetValue(1, 7).ToString();
                string valorPasivos = MyValues.GetValue(1, 8).ToString();
                string criteriosContables = MyValues.GetValue(1, 9).ToString();

                //Comprueba si existe el FIP para agregarlo a la lista
                if (!fipList.Any(obj => obj.rutFondo == fipRut))
                {
                    fipList.Add(
                        new Fip
                        {
                            rutFondo = fipRut,
                            digitoFondo = digitoFondo,
                            denominacionFondo = denominacionFondo,
                            valorActivos = valorActivos,
                            valorPasivos = valorPasivos,
                            criteriosContables = criteriosContables
                        }
                    );
                }

                
            }
            //El segundo proceso es para agregar aportantes a la lista de fondos de inversión privada
            foreach(Fip fip in fipList)
            {
                //Agrega los fondos de inversión al XML
                XmlElement newFipElement = (XmlElement)fondosRootElement.AppendChild(doc.CreateElement("fondoInversionPrivado"));
                //Agrega el contenido de esos elementos
                newFipElement.AppendChild(doc.CreateElement("rutFondo")).InnerText = fip.rutFondo;
                newFipElement.AppendChild(doc.CreateElement("digitoFondo")).InnerText = fip.digitoFondo;
                newFipElement.AppendChild(doc.CreateElement("denominacionFondo")).InnerText = fip.denominacionFondo;
                newFipElement.AppendChild(doc.CreateElement("valorActivos")).InnerText = fip.valorActivos;
                newFipElement.AppendChild(doc.CreateElement("valorPasivos")).InnerText = fip.valorPasivos;
                newFipElement.AppendChild(doc.CreateElement("criteriosContables")).InnerText = fip.criteriosContables;

                //Agrega un nodo nuevo para los participes
                newFipElement.AppendChild(doc.CreateElement("participes"));
            }

            
            //El tercer proceso es para agregar a todos los aportantes a los fondos de inversión privada
            XmlNodeList fipNodeList = doc.SelectNodes("informacionAFIP/fondos/fondoInversionPrivado");
            foreach (XmlNode fipNode in fipNodeList)
            {
                //Recorre todos los registros nuevamente para agregarlos al fondo correspondiente
                for (int index = 2; index <= lastRow - 1; index++)
                {
                    //Obtiene la fila
                    System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "R" + index.ToString()).Cells.Value;
                    //Si es igual lo agrega
                    if (fipNode["rutFondo"].InnerText == MyValues.GetValue(1, 4).ToString())
                    {
                        //Valores null
                        string apellidoPaterno;
                        string apellidoMaterno;
                        string primerNombre;
                        string segundoNombre;

                        if (MyValues.GetValue(1, 13) == null){ apellidoPaterno = "";}else{ apellidoPaterno = MyValues.GetValue(1, 13).ToString();}
                        if (MyValues.GetValue(1, 14) == null) { apellidoMaterno = ""; } else {  apellidoMaterno = MyValues.GetValue(1, 14).ToString(); }
                        if (MyValues.GetValue(1, 15) == null) { primerNombre = ""; } else { primerNombre = MyValues.GetValue(1, 15).ToString(); }
                        if (MyValues.GetValue(1, 16) == null) { segundoNombre = ""; } else { segundoNombre = MyValues.GetValue(1, 16).ToString(); }

                        XmlElement newFipAportant = (XmlElement)fipNode["participes"].AppendChild(doc.CreateElement("aportante"));
                        newFipAportant.AppendChild(doc.CreateElement("rutAportante")).InnerText = MyValues.GetValue(1, 10).ToString();
                        newFipAportant.AppendChild(doc.CreateElement("digitoAportante")).InnerText = MyValues.GetValue(1, 11).ToString();
                        newFipAportant.AppendChild(doc.CreateElement("extranjero")).InnerText = MyValues.GetValue(1, 12).ToString();
                        newFipAportant.AppendChild(doc.CreateElement("apellidoPaterno")).InnerText = apellidoPaterno;
                        newFipAportant.AppendChild(doc.CreateElement("apellidoMaterno")).InnerText = apellidoMaterno;
                        newFipAportant.AppendChild(doc.CreateElement("primerNombre")).InnerText = primerNombre;
                        newFipAportant.AppendChild(doc.CreateElement("segundoNombre")).InnerText = segundoNombre;
                        newFipAportant.AppendChild(doc.CreateElement("montoParticipacion")).InnerText = MyValues.GetValue(1, 17).ToString();
                        newFipAportant.AppendChild(doc.CreateElement("numeroCuotas")).InnerText = MyValues.GetValue(1, 18).ToString();
                    }
                }
                
            }

            doc.Save(rutaExportText.Text + @"\svsFile.xml");
            MessageBox.Show("Archivo guardado en: " + rutaExportText.Text + @"\svsFile.xml");

            //ValidateXmlWithXsd(@"C:\svsFile" + dateText.Text + ".xml", Application.StartupPath + @"\\fpapo.xsd");
        }

        //Abre el dialogo de archivo
        private void abrirBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirExcelDialog = new OpenFileDialog();
            DialogResult result = abrirExcelDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                archivoText.Text = abrirExcelDialog.FileName;
            }
        }

        //Abre el diálogo de selección de carpeta
        private void exportBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                rutaExportText.Text = folderDialog.SelectedPath;
            }
        }

        //Valida el XSD
        private static void ValidateXmlWithXsd(string xmlUri, string xsdUri)
        {
            try
            {
                XmlReaderSettings xmlSettings = new XmlReaderSettings();
                xmlSettings.Schemas = new System.Xml.Schema.XmlSchemaSet();
                xmlSettings.Schemas.Add("informacionAFIP", xsdUri);
                xmlSettings.ValidationType = ValidationType.Schema;
                XmlReader reader = XmlReader.Create(xmlUri, xmlSettings);

                // Parse the file.
                while (reader.Read());

                MessageBox.Show("Archivo Válido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
