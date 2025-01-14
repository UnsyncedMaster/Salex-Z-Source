using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.IO;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using ICSharpCode.AvalonEdit.Highlighting;
using System.Xml;
using System.Xaml;
using System.Windows.Media.Effects;
using System.Web;
using System.Net;

namespace Salex_Z
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            p1.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Hidden;
            p4.Visibility = Visibility.Hidden;
            p5.Visibility = Visibility.Hidden;
            p6.Visibility = Visibility.Hidden;
            p7.Visibility = Visibility.Hidden;
            s1.Visibility = Visibility.Hidden;
            s2.Visibility = Visibility.Hidden;
            s3.Visibility = Visibility.Hidden;
            s4.Visibility = Visibility.Hidden;
            s5.Visibility = Visibility.Hidden;
            s6.Visibility = Visibility.Hidden;
            s7.Visibility = Visibility.Hidden;
            s8.Visibility = Visibility.Hidden;
            s9.Visibility = Visibility.Hidden;
            s10.Visibility = Visibility.Hidden;
            s12.Visibility = Visibility.Hidden;
            s13.Visibility = Visibility.Hidden;
            s14.Visibility = Visibility.Hidden;
            s15.Visibility = Visibility.Hidden;
            s11.Visibility = Visibility.Hidden;
            s16.Visibility = Visibility.Hidden;
            s17.Visibility = Visibility.Hidden;
            s18.Visibility = Visibility.Hidden;
            s7_Copy.Visibility = Visibility.Hidden;
            s8_Copy.Visibility = Visibility.Hidden;
            s9_Copy.Visibility = Visibility.Hidden;
            s10_Copy.Visibility = Visibility.Hidden;
            s12_Copy.Visibility = Visibility.Hidden;
            s13_Copy.Visibility = Visibility.Hidden;
            s14_Copy.Visibility = Visibility.Hidden;
            s15_Copy.Visibility = Visibility.Hidden;
            s11_Copy.Visibility = Visibility.Hidden;
            s16_Copy.Visibility = Visibility.Hidden;
            s17_Copy.Visibility = Visibility.Hidden;
            s18_Copy.Visibility = Visibility.Hidden;

            s17_Copy.IsChecked = true;

            Listbox.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo("./Scripts");
            FileInfo[] file = directory.GetFiles("*.txt");
            foreach (FileInfo files in file)
            {
                Listbox.Items.Add(files.Name);
            }

            Stream xs = File.OpenRead(Environment.CurrentDirectory + @"\bin\" + "Dark.xshd"); // replace "bin" with directory and replace "Dark" with file name
            XmlTextReader x = new XmlTextReader(xs);
            Editor.SyntaxHighlighting = HighlightingLoader.Load(x, HighlightingManager.Instance);
            xs.Close();
            x.Close();
            Editor.TextArea.TextView.LinkTextBackgroundBrush = Brushes.Transparent;
            Editor.TextArea.TextView.LinkTextForegroundBrush = Brushes.LightGreen;
            Editor.TextArea.TextView.LinkTextUnderline = false;
            // Thanks to immune lion for the code and syntax




        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
         p1.Visibility = Visibility.Hidden;
            p2.Visibility = Visibility.Hidden;
            p3.Visibility = Visibility.Hidden;
            p4.Visibility = Visibility.Hidden;
            p5.Visibility = Visibility.Hidden;
            p6.Visibility = Visibility.Hidden;
            p7.Visibility = Visibility.Hidden;
            s1.Visibility = Visibility.Hidden;
            s2.Visibility = Visibility.Hidden;
            s3.Visibility = Visibility.Hidden;
            s4.Visibility = Visibility.Hidden;
            s5.Visibility = Visibility.Hidden;
            s6.Visibility = Visibility.Hidden;
            s7.Visibility = Visibility.Hidden;
            s8.Visibility = Visibility.Hidden;
            s9.Visibility = Visibility.Hidden;
            s10.Visibility = Visibility.Hidden;
            s12.Visibility = Visibility.Hidden;
            s13.Visibility = Visibility.Hidden;
            s14.Visibility = Visibility.Hidden;
            s15.Visibility = Visibility.Hidden; 
            s11.Visibility = Visibility.Hidden;
            s16.Visibility = Visibility.Hidden;
            s17.Visibility = Visibility.Hidden;
            s18.Visibility = Visibility.Hidden;
            s7_Copy.Visibility = Visibility.Hidden;
            s8_Copy.Visibility = Visibility.Hidden;
            s9_Copy.Visibility = Visibility.Hidden;
            s10_Copy.Visibility = Visibility.Hidden;
            s12_Copy.Visibility = Visibility.Hidden;
            s13_Copy.Visibility = Visibility.Hidden;
            s14_Copy.Visibility = Visibility.Hidden;
            s15_Copy.Visibility = Visibility.Hidden;
            s11_Copy.Visibility = Visibility.Hidden;
            s16_Copy.Visibility = Visibility.Hidden;
            s17_Copy.Visibility = Visibility.Hidden;
            s18_Copy.Visibility = Visibility.Hidden;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            p1.Visibility = Visibility.Visible;
            p2.Visibility = Visibility. Visible;
            p3.Visibility = Visibility.Visible;
            p4.Visibility = Visibility.Visible;
            p5.Visibility = Visibility.Visible;
            p6.Visibility = Visibility.Visible;
            p7.Visibility = Visibility.Visible;
            s1.Visibility = Visibility.Hidden;
            s2.Visibility = Visibility.Hidden;
            s3.Visibility = Visibility.Hidden;
            s4.Visibility = Visibility.Hidden;
            s5.Visibility = Visibility.Hidden;
            s6.Visibility = Visibility.Hidden;
            s7.Visibility = Visibility.Hidden;
            s8.Visibility = Visibility.Hidden;
            s9.Visibility = Visibility.Hidden;
            s10.Visibility = Visibility.Hidden;
            s12.Visibility = Visibility.Hidden;
            s13.Visibility = Visibility.Hidden;
            s14.Visibility = Visibility.Hidden;
            s15.Visibility = Visibility.Hidden;
            s11.Visibility = Visibility.Hidden;
            s16.Visibility = Visibility.Hidden;
            s17.Visibility = Visibility.Hidden;
            s18.Visibility = Visibility.Hidden;
            s7_Copy.Visibility = Visibility.Hidden;
            s8_Copy.Visibility = Visibility.Hidden;
            s9_Copy.Visibility = Visibility.Hidden;
            s10_Copy.Visibility = Visibility.Hidden;
            s12_Copy.Visibility = Visibility.Hidden;
            s13_Copy.Visibility = Visibility.Hidden;
            s14_Copy.Visibility = Visibility.Hidden;
            s15_Copy.Visibility = Visibility.Hidden;
            s11_Copy.Visibility = Visibility.Hidden;
            s16_Copy.Visibility = Visibility.Hidden;
            s17_Copy.Visibility = Visibility.Hidden;
            s18_Copy.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Slider_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Slider_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
           
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            s1.Visibility = Visibility.Visible;
            s2.Visibility = Visibility.Visible;
            s3.Visibility = Visibility.Visible;
            s4.Visibility = Visibility.Visible;
            s5.Visibility = Visibility.Visible;
            s6.Visibility = Visibility. Visible;
            s7.Visibility = Visibility.Visible;
            s8.Visibility = Visibility.Visible;
            s9.Visibility = Visibility.Visible;
            s10.Visibility = Visibility.Visible;
            s11.Visibility = Visibility.Visible;
            s12.Visibility = Visibility.Visible;
            s13.Visibility = Visibility.    Visible;
            s14.Visibility = Visibility.Visible;
            s15.Visibility = Visibility.Visible;
            s16.Visibility = Visibility.Visible;
            s17.Visibility = Visibility.Visible;
            s18.Visibility = Visibility.Visible;
        }

        private void s6_Click(object sender, RoutedEventArgs e)
        {
            s7.Visibility = Visibility.Hidden;
            s8.Visibility = Visibility.Hidden;
            s9.Visibility = Visibility.Hidden;
            s10.Visibility = Visibility.Hidden;
            s12.Visibility = Visibility.Hidden;
            s13.Visibility = Visibility.Hidden;
            s14.Visibility = Visibility.Hidden;
            s15.Visibility = Visibility.Hidden;
            s11.Visibility = Visibility.Hidden;
            s16.Visibility = Visibility.Hidden;
            s17.Visibility = Visibility.Hidden;
            s18.Visibility = Visibility.Hidden;
            s7_Copy.Visibility = Visibility.Visible;
            s8_Copy.Visibility = Visibility.Visible;
            s9_Copy.Visibility = Visibility.Visible;
            s10_Copy.Visibility = Visibility.Visible;
            s12_Copy.Visibility = Visibility.Visible;
            s13_Copy.Visibility = Visibility.Visible;
            s14_Copy.Visibility = Visibility.Visible;
            s15_Copy.Visibility = Visibility.Visible;
            s11_Copy.Visibility = Visibility.Visible;
            s16_Copy.Visibility = Visibility.Visible;
            s17_Copy.Visibility = Visibility.Visible;
            s18_Copy.Visibility = Visibility.Visible;

        }

        private void s4_Click(object sender, RoutedEventArgs e)
        {
            s7.Visibility = Visibility.Visible;
            s8.Visibility = Visibility.Visible;
            s9.Visibility = Visibility.Visible;
            s10.Visibility = Visibility.Visible;
            s12.Visibility = Visibility.Visible;
            s13.Visibility = Visibility.Visible;
            s14.Visibility = Visibility.    Visible;
            s15.Visibility = Visibility.Visible;
            s11.Visibility = Visibility.Visible;
            s16.Visibility = Visibility.Visible;
            s17.Visibility = Visibility.Visible;
            s18.Visibility = Visibility.Visible;
            s7_Copy.Visibility = Visibility.Hidden;
            s8_Copy.Visibility = Visibility.Hidden;
            s9_Copy.Visibility = Visibility.Hidden;
            s10_Copy.Visibility = Visibility.Hidden;
            s12_Copy.Visibility = Visibility.Hidden;
            s13_Copy.Visibility = Visibility.Hidden;
            s14_Copy.Visibility = Visibility.Hidden;
            s15_Copy.Visibility = Visibility.Hidden;
            s11_Copy.Visibility = Visibility.Hidden;
            s16_Copy.Visibility = Visibility.Hidden;
            s17_Copy.Visibility = Visibility.Hidden;
            s18_Copy.Visibility = Visibility.Hidden;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (s16_Copy.IsChecked == true) 
            {
                //api3.LaunchExploit();
                
            }
          else  if (s17_Copy.IsChecked == true) 
            {
                //api2.LaunchExploit();
            }
            else if (s18_Copy.IsChecked == true)
            {
                //api1.Inject();
            }
           
        }

        private void chec_Checked(object sender, RoutedEventArgs e)
        {
            s16_Copy.IsChecked = false;
            s18_Copy.IsChecked = false;
        }

        private void s16_Copy_Checked(object sender, RoutedEventArgs e)
        {
            s17_Copy.IsChecked = false;
            s18_Copy.IsChecked = false;
        }

        private void s18_Copy_Checked(object sender, RoutedEventArgs e)
        {
            s17_Copy.IsChecked = false;
            s16_Copy.IsChecked = false;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (s16_Copy.IsChecked == true)
            {
               // api3.ExecuteScript(Editor.Text);
            }
            else if (s17_Copy.IsChecked == true)
            {
               // api2.SendLuaScript(Editor.Text);
            }
            else if (s18_Copy.IsChecked == true)
            {
               // api1.Execute(Editor.Text);
            }
        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Editor.Text = File.ReadAllText($"./Scripts/{Listbox.SelectedItem}");
        }

        private void Editor_MouseHover(object sender, MouseEventArgs e)
        {
         

        }

     

        private void s17_Checked_1(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.55;
        }

        private void s16_Checked(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
        }

        private void s16_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Topmost= false;
        }

        private void s17_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Editor.Text = "";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog FileOpen = new Microsoft.Win32.OpenFileDialog();
            FileOpen.Filter = "*Txt (*.txt)|*.txt|Lua (*.lua)|*.lua";

            if (FileOpen.ShowDialog() == true)
            {
                string text = File.ReadAllText(FileOpen.FileName);
              Editor.Text = text;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog SF = new Microsoft.Win32.SaveFileDialog();
            SF.Filter = "*Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua";

            if (SF.ShowDialog() == true)
            {
                Stream SF1 = SF.OpenFile();
                StreamWriter SF2 = new StreamWriter(SF1);
               
                SF2.Write(Editor.Text);
                SF2.Close();
                SF1.Close();
            }
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
           var WebClient = new WebClient();
            string Script = WebClient.DownloadString("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt");
            if (s16_Copy.IsChecked == true)
            {
                //api3.ExecuteScript(Script);
            }
            else if (s17_Copy.IsChecked == true)
            {
               // api2.SendLuaScript(Script);
            }
            else if (s18_Copy.IsChecked == true)
            {
                //api1.Execute(Script);
            }
            WebClient.Dispose();
        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {
            var WebClient = new WebClient();
            string Script = WebClient.DownloadString("https://raw.githubusercontent.com/CMD-X/CMD-X/master/Source");
            if (s16_Copy.IsChecked == true)
            {
                //api3.ExecuteScript(Script);
            }
            else if (s17_Copy.IsChecked == true)
            {
                //api2.SendLuaScript(Script);
            }
            else if (s18_Copy.IsChecked == true)
            {
               // api1.Execute(Script);
            }
            WebClient.Dispose();
        }
    }
}
