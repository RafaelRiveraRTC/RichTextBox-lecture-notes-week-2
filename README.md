# RichTextBox lecture notes week 2

Richtext box: a box that accepts text, will accept paragrpaphs
and larger text

 //Steps
            //1.Create string variables for first and last name
            string firstName = First.Text;
            string lastName = Last.Text;
            //2. Concatinate them together to form a full name
            //This is an example of string interpolation
            string fullName = $"{firstName} {lastName}";
            //3. Display that information to our label
            LbL.Content = fullName;


double click the button to make a click event

ex is the error object, .message only displays message,to string will display the full info behind the error

make sure the button,textbox and label names match in the .cs file

int number = int.Parse(firstName)/int.Parse(lastName);

catch(DividdeByZeroException dvz) messageBox.Show(You cannot divide by zero);

Flow documents sit inside your rich text box,they are like a peice of paper

<paragrpah> Paragraph of text

<run> is a single sentence

Flow document is an object with a list of paragraphs,with a list of runs. 

You don't name the rich text box you name the run

Adding a new rich text box for typing your address

Add a label for the rich text box

Properly name the run tag

 Write the code to grab the text from RTB
 string address = runHomeInfo

  Display it to our original runDisplay

  Any time you can change the text, use.Text,otherwise use .label