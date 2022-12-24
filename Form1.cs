namespace GUI_with_Tab;

public partial class Form1 : Form
{
    public Form1()
    {
         
        InitializeComponent();

    //-------------------------LET'S CREATE A MENU !!!! -------------------------------
        //To create a Menu bar it is required to create a MenuStrip, several ToolStripMenuItem (as much as desired), Dropdownitems for each ToolStripMenuItem.
        //Here it is define the Menu bar
        MenuStrip MainMenu = new MenuStrip(); 
        MainMenu.BackColor = Color.OrangeRed;  
        MainMenu.ForeColor = Color.Black;  
        Controls.Add(MainMenu) ;            //IMPORTANT: add it to the Form!!

        //Let's create the first ToolStripMenuItem
        ToolStripMenuItem FileMenu = new ToolStripMenuItem();  
        FileMenu.BackColor = Color.Blue;  
        FileMenu.ForeColor = Color.Black;  
        FileMenu.Text = "File Menu";  
        FileMenu.TextAlign = ContentAlignment.BottomRight;  
        //FileMenu.ToolTipText = "Click Me"; 
        MainMenu.Items.Add(FileMenu);               //IMPORTANT: add the ToolStripMenuItem to the MenuStrip!
        FileMenu.DropDownItems.Add("Menu 1");       //Let's create the "child" elements
        FileMenu.DropDownItems.Add("Menu 2");
        // here it is defined an event for 1 of the Childs
        FileMenu.DropDownItems[0].Click += new EventHandler (Perform_Event);
        void Perform_Event(object? sender, EventArgs e){
            MessageBox.Show("Event!");
        }

       //Let's create the second ToolStripMenuItem
        ToolStripMenuItem SettingsMenu = new ToolStripMenuItem();  
        SettingsMenu.BackColor = Color.White;  
        SettingsMenu.ForeColor = Color.Black;  
        SettingsMenu.Text = "Settings Menu";  
        SettingsMenu.TextAlign = ContentAlignment.BottomRight;  
        MainMenu.Items.Add(SettingsMenu);

        SettingsMenu.DropDownItems.Add("Setting 1");
        SettingsMenu.DropDownItems.Add("Setting 2");
        SettingsMenu.DropDownItems.Add("Quit");

        SettingsMenu.DropDownItems[2].Click += new EventHandler (Quit_App);
        void Quit_App(object? sender, EventArgs e){
            Close();
        }

    //-------------------------LET'S CREATE TABS !!!! -------------------------------
        //To create different tabs, it is required to create the TabControl and, afterwards, as much TabPage as desired
        //Let's create the TabControl
        TabControl Mytabcontrol = new TabControl();
        Mytabcontrol.Location = new Point(0, 25);
        Mytabcontrol.Size = new System.Drawing.Size(600, 600);
        Controls.Add(Mytabcontrol);         //IMPORTANT: add it to the Form!
        

        //Let's create the first TabPage
        TabPage tabPage1 = new System.Windows.Forms.TabPage();
        tabPage1.Text = "Option 1";
        tabPage1.Size = new System.Drawing.Size(400, 400);
        tabPage1.TabIndex = 0;
        tabPage1.Height = 800;
        //Let's create the first TabPage
        TabPage tabPage2 = new System.Windows.Forms.TabPage();
        tabPage2.Text = "Option 2";
        tabPage2.Size = new System.Drawing.Size(400, 400);
        tabPage2.TabIndex = 1;
        //IMPORTANT! Add each TagPage to the TabControl!!
        Mytabcontrol.Controls.Add(tabPage1);
        Mytabcontrol.Controls.Add(tabPage2);


        //Let's add elements (1 label) to the first TabPage
        Label tab1Label1 = new Label();
        tab1Label1.Location = new System.Drawing.Point(16, 24);
        tab1Label1.Text = "label1";
        tab1Label1.Size = new System.Drawing.Size(500, 500);
        tabPage1.Controls.Add(tab1Label1);  //IMPORTANT! Add the element to the TagPage!!

        //Let's add elements (1 ComboBox) to the second TabPage
        ComboBox tab2combobox1 = new ComboBox();
        tab2combobox1.Location = new System.Drawing.Point(16, 24);
        tab2combobox1.Text = "Select and option...";
        tab2combobox1.Size = new System.Drawing.Size(250, 40);
        tab2combobox1.Items.Add("Madrid");
        tab2combobox1.Items.Add("Bacerlona");
        tab2combobox1.Items.Add("Valencia");
        tabPage2.Controls.Add(tab2combobox1);  //IMPORTANT! Add the element to the TagPage!!


    }
}
