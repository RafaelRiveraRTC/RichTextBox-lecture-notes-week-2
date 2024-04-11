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

namespace RichTextBox_lecture_notes_week_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //main window
        }
        //This is a demonstration of a summary

        //summary
        /// Test method to 
        /// summary
        /// <param name="number1">Number to pass in</param>
        /// <param name="word1">word to pass in</param>
        /// 

        public string TestMethod(int number1, string word1)
        {
            return "";
        }

        private void Info_Display(object sender, RoutedEventArgs e)
        {
            try
            {
                //Steps
                //1.Create string variables for first and last name
                string firstName = First.Text;
                string lastName = Last.Text;
                
                //2. Concatinate them together to form a full name
                //This is an example of string interpolation
                string fullName = $"{firstName} {lastName}";
                //3. Display that information to our label
                LbL.Content = fullName;

                //4.Display to rich textbox
                runDisplay.Text = fullName;

                // Add a new Rich Text Box for getting an address
                // Add a label for the Rich Text box
                // Properly name the "Run" tag
                // Write the code to grab the text from RTB
                string address = runHomeInfo.Text;
                // Display it to our original runDisplay

                //two line breaks
                runDisplay.Text += "/n/n";

                //Append the address
                runDisplay.Text += address;

                //Full Name


            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

          

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }//class


}//program