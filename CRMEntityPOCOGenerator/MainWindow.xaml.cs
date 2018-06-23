using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace CRMEntityPOCOGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void WriteClassDetails(Type item);

        public string[] BlockList = { "Item", "RowState", "RowError", "Table", "HasErrors", "ItemArray" };
        public Assembly LoadedAssembly;
        List<string> CodeLines = new List<string>();

        public List<string> PropertyNames { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LoadedAssembly = Assembly.LoadFile(@"C:\Liberty.CRM.CMO.XRM.dll");
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            ClassWriter(WCFDataContracts);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ClassWriter(WriteClassDetails MethodName)
        {
            CodeLines.Clear();
            CodeLines.Add(@"----------- Data Contracts ---------");
            //CodeLines.AddRange(LoadDataTables().ToArray());
            if (LoadedAssembly != null)
            {
                Type[] types = LoadedAssembly.GetTypes();
                foreach (Type item in types)
                {
                    try
                    {
                        if (item.IsClass)
                        {
                            if (item.BaseType.Name == "CrmEntity")
                            {
                                MethodName(item);
                            }

                        }

                    }
                    catch (Exception ee)
                    {
                        throw ee;
                    }
                }
            }
            CodeLines.Clear();
        }

        private void WCFDataContracts(Type item)
        {
            string NullablePropertyType = "";
            CodeLines.Clear();
            string ClassName = item.Name;
            //WCFContractUsings();
            CodeLines.Add(@"[DataContract]");
            CodeLines.Add(@"public class " + ClassName);
            CodeLines.Add(@"{");
            PropertyInfo[] infolist = item.GetProperties();
            foreach (PropertyInfo itemb in infolist)
            {
                try
                {
                    if (itemb.PropertyType.BaseType.Name != "DataRow")
                    {
                        if (!BlockList.Contains(itemb.Name))
                        {
                            CodeLines.Add(@"[DataMember]");
                            if (itemb.PropertyType.ToString() == @"System.Nullable`1[System.Int32]")
                                NullablePropertyType = @"System.Int32?";
                            else
                                NullablePropertyType = itemb.PropertyType.ToString();

                            CodeLines.Add(@"public " + NullablePropertyType+ " " + itemb.Name + @" { get; set; }");
                        }
                    }
                }
                catch
                {


                }

            }
            CodeLines.Add(@"}");
            CodeLines.Add(@"}");//namespace closing
            WriteSeperateFile(item.Name.Remove(item.Name.Length - 3, 3) + "Contract", CodeLines);
        }


        private void WriteSeperateFile(string FileName, List<string> list)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Temp\" + FileName + ".cs");
            foreach (string item in list)

                sw.WriteLine(item.ToString());

            sw.Close();

        }
    }

}
