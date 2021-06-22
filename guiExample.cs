/*======= SUMMARY TO READ ============
I see that you may be required in pure C# instead of XAML (easier)
So here is an example of creating a GUI purely in C# but using WPF

A few things :: WPF is a framework (i.e hsaves the trouble of rewritting our classes to make things work)

Options:
XAML + C#
C# only (given in this example) 

*/
using System.Windows;               //let gain access to windows
using System.Windows.Controls;      //and the windows controls

namespace WPFXAMLOverview { 
   /// <summary> 
      /// Interaction logic for MainWindow.xaml  (IF YOU WANT TO MIX)
   /// </summary> 
	
   public partial class MainWindow : Window { 
	
      public MainWindow() { 
         InitializeComponent(); 
			
         //This panel is for viewing
         StackPanel stackPanel = new StackPanel();  //this literally creates panels in the window to place components
         this.Content = stackPanel; 
			
         //Buttons are for clicking
         Button button = new Button();        //call the preset button function
         button.Content = "DO SOMETHING";     //what you see on the button 
         button.HorizontalAlignment = HorizontalAlignment.Left;  //You can align this to center and right as well
         button.Margin = new Thickness(150);           //use preset thickness function to define the spacing arounf the button (margin)
         button.VerticalAlignment = VerticalAlignment.Top;  //again aligning up and down
         button.Width = 75;  // set the width of your button
         stackPanel.Children.Add(button);   // take the panel we created, and under the children as the button we have been creating
      } 
   } 
} 
