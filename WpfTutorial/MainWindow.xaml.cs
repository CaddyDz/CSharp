using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GenerateDoc();
        }

        private void MyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if (calendar.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                try
                {
                    tbDateSelected.Text = date.ToShortDateString();
                }
                catch(NullReferenceException)
                {

                }
            }
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            var radiobutton = sender as RadioButton;
            string radioBPressed = radiobutton.Content.ToString();
            if (radioBPressed == "Draw") {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Ink;
            } else if (radioBPressed == "Erase") {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
            } else if (radioBPressed == "Select") {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Select;
            }
        }

        private void DrawPanel_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int) e.Key >= 35 && (int) e.Key <= 68)
            {
                switch ((int) e.Key)
                {
                    case 35:
                        strokeAttr.Width = 2;
                        strokeAttr.Height = 2;
                        break;
                    case 36:
                        strokeAttr.Width = 4;
                        strokeAttr.Height = 4;
                        break;
                    case 37:
                        strokeAttr.Width = 6;
                        strokeAttr.Height = 6;
                        break;
                    case 38:
                        strokeAttr.Width = 8;
                        strokeAttr.Height = 8;
                        break;
                    case 39:
                        strokeAttr.Width = 10;
                        strokeAttr.Height = 10;
                        break;
                    case 40:
                        strokeAttr.Width = 12;
                        strokeAttr.Height = 12;
                        break;
                    case 41:
                        strokeAttr.Width = 14;
                        strokeAttr.Height = 14;
                        break;
                    case 42:
                        strokeAttr.Width = 16;
                        strokeAttr.Height = 16;
                        break;
                    case 43:
                        strokeAttr.Width = 18;
                        strokeAttr.Height = 18;
                        break;
                    case 45:
                        strokeAttr.Color = (Color) ColorConverter.ConvertFromString("Blue");
                        break;
                    case 50:
                        strokeAttr.Color = (Color)ColorConverter.ConvertFromString("Green");
                        break;
                    case 68:
                        strokeAttr.Color = (Color)ColorConverter.ConvertFromString("Yellow");
                        break;
                }

            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("MyPictures.bin", FileMode.Create))
            {
                this.DrawingCanvas.Strokes.Save(fs);
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("MyPictures.bin", FileMode.Open, FileAccess.Read))
            {
                StrokeCollection sc = new StrokeCollection(fs);
                this.DrawingCanvas.Strokes = sc;
            }
        }

        private void GenerateDoc()
        {
            FlowDocument doc = new FlowDocument();

            Paragraph para = new Paragraph(new Run("Either the well was very deep, or she fell very slowly, for she had plenty of time as she went down to look about her and to wonder what was going to happen next.First, she tried to look down and make out what she was coming to, but it was too dark to see anything; then she looked at the sides of the well, and noticed that they were filled with cupboards and book-shelves; here and there she saw maps and pictures hung upon pegs.She took down a jar from one of the shelves as she passed; it was labelled 'ORANGE MARMALADE', but to her great disappointment it was empty: she did not like to drop the jar for fear of killing somebody, so managed to put it into one of the cupboards as she fell past it."));

            doc.Blocks.Add(para);

            para = new Paragraph(new Run("Either the well was very deep, or she fell very slowly, for she had plenty of time as she went down to look about her and to wonder what was going to happen next.First, she tried to look down and make out what she was coming to, but it was too dark to see anything; then she looked at the sides of the well, and noticed that they were filled with cupboards and book-shelves; here and there she saw maps and pictures hung upon pegs.She took down a jar from one of the shelves as she passed; it was labelled 'ORANGE MARMALADE', but to her great disappointment it was empty: she did not like to drop the jar for fear of killing somebody, so managed to put it into one of the cupboards as she fell past it."))
            {
                FontSize = 14,
                FontStyle = FontStyles.Italic,
                Foreground = Brushes.Green
            };
            doc.Blocks.Add(para);
            fdScrollViewer.Document = doc;
        }

        private void RichTB_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            if (rtb == null) return;
            ContextMenu contextMenu = rtb.ContextMenu;
            contextMenu.PlacementTarget = rtb;
            contextMenu.Placement = PlacementMode.RelativePoint;
            TextPointer position = rtb.Selection.End;

            if (position == null) return;
            Rect positionRect = position.GetCharacterRect(LogicalDirection.Forward);
            contextMenu.HorizontalOffset = positionRect.X;
            contextMenu.VerticalOffset = positionRect.Y;

            contextMenu.IsOpen = true;
            e.Handled = true;
        }

        void SaveRTBContent(object sender, RoutedEventArgs e)
        {
            TextRange range = new TextRange(RichTB.Document.ContentStart, RichTB.Document.ContentEnd);
            FileStream fStream = new FileStream(@"C:\Users\Salim\C#Data\text.xaml", FileMode.Create);

            range.Save(fStream, DataFormats.XamlPackage);
            fStream.Close();
        }

        void OpenRTBContent(object sender, RoutedEventArgs e)
        {
            TextRange range;
            FileStream fStream;

            if(File.Exists(@"C:\Users\Salim\C#Data\text.xaml"))
            {
                range = new TextRange(RichTB.Document.ContentStart, RichTB.Document.ContentEnd);
                fStream = new FileStream(@"C:\Users\Salim\C#Data\text.xaml", FileMode.OpenOrCreate);
                range.Load(fStream, DataFormats.XamlPackage);
                fStream.Close();
            }
            
        }
    }
}