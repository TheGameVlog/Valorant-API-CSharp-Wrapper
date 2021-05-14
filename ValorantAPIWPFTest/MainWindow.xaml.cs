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
using ValorantAPIWrapper;

namespace ValorantAPIWPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ValorantClient vClient = new ValorantClient();
        List<Agents> agents;

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {           
            lstAgents.ItemsSource=agents;
            

        }

        private void mainWindow_Initialized(object sender, EventArgs e)
        {
            agents = vClient.GetAgents();
            lstAgents.SelectedIndex = 0;
        }

        private void lstAgents_Selected(object sender, RoutedEventArgs e)
        {
            Agents selectedAgent= lstAgents.SelectedItem as Agents;

            lblAgentName.Text = selectedAgent.DisplayName;
            agentIcon.Source = new BitmapImage(new Uri(selectedAgent.DisplayIcon, UriKind.RelativeOrAbsolute));
            lblDescription.Text = selectedAgent.Description;
            
            
        }
    }
}
