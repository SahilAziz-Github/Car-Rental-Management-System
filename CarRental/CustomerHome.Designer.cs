namespace CarRental
{
    partial class CustomerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCustomerHome = new MetroFramework.Controls.MetroPanel();
            this.buttonInvoice = new MetroFramework.Controls.MetroButton();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelShowName = new System.Windows.Forms.Label();
            this.buttonDateTime = new MetroFramework.Controls.MetroDateTime();
            this.buttonShowAll = new MetroFramework.Controls.MetroButton();
            this.buttonMenu = new MetroFramework.Controls.MetroButton();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonSearch = new MetroFramework.Controls.MetroButton();
            this.textSearch = new MetroFramework.Controls.MetroTextBox();
            this.buttonBook = new MetroFramework.Controls.MetroButton();
            this.contextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCustomerHome2 = new MetroFramework.Controls.MetroPanel();
            this.gridCustomerHome = new MetroFramework.Controls.MetroGrid();
            this.panelCustomerHome.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.panelCustomerHome2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCustomerHome
            // 
            this.panelCustomerHome.BackColor = System.Drawing.Color.DarkCyan;
            this.panelCustomerHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCustomerHome.BackgroundImage")));
            this.panelCustomerHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCustomerHome.Controls.Add(this.buttonInvoice);
            this.panelCustomerHome.Controls.Add(this.labelShow);
            this.panelCustomerHome.Controls.Add(this.labelShowName);
            this.panelCustomerHome.Controls.Add(this.buttonDateTime);
            this.panelCustomerHome.Controls.Add(this.buttonShowAll);
            this.panelCustomerHome.Controls.Add(this.buttonMenu);
            this.panelCustomerHome.Controls.Add(this.labelWelcome);
            this.panelCustomerHome.Controls.Add(this.buttonSearch);
            this.panelCustomerHome.Controls.Add(this.textSearch);
            this.panelCustomerHome.Controls.Add(this.buttonBook);
            this.panelCustomerHome.HorizontalScrollbarBarColor = true;
            this.panelCustomerHome.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCustomerHome.HorizontalScrollbarSize = 10;
            this.panelCustomerHome.Location = new System.Drawing.Point(0, 38);
            this.panelCustomerHome.Name = "panelCustomerHome";
            this.panelCustomerHome.Size = new System.Drawing.Size(425, 753);
            this.panelCustomerHome.TabIndex = 0;
            this.panelCustomerHome.UseCustomBackColor = true;
            this.panelCustomerHome.UseCustomForeColor = true;
            this.panelCustomerHome.VerticalScrollbarBarColor = true;
            this.panelCustomerHome.VerticalScrollbarHighlightOnWheel = false;
            this.panelCustomerHome.VerticalScrollbarSize = 10;
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.BackColor = System.Drawing.Color.Transparent;
            this.buttonInvoice.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInvoice.Location = new System.Drawing.Point(32, 529);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(273, 62);
            this.buttonInvoice.TabIndex = 6;
            this.buttonInvoice.Text = "Get Invoice";
            this.buttonInvoice.UseCustomBackColor = true;
            this.buttonInvoice.UseCustomForeColor = true;
            this.buttonInvoice.UseSelectable = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.BackColor = System.Drawing.Color.Transparent;
            this.labelShow.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(29, 124);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(0, 53);
            this.labelShow.TabIndex = 10;
            // 
            // labelShowName
            // 
            this.labelShowName.AutoSize = true;
            this.labelShowName.BackColor = System.Drawing.Color.Gray;
            this.labelShowName.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowName.Location = new System.Drawing.Point(32, 124);
            this.labelShowName.Name = "labelShowName";
            this.labelShowName.Size = new System.Drawing.Size(0, 50);
            this.labelShowName.TabIndex = 9;
            // 
            // buttonDateTime
            // 
            this.buttonDateTime.Location = new System.Drawing.Point(32, 375);
            this.buttonDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.buttonDateTime.Name = "buttonDateTime";
            this.buttonDateTime.Size = new System.Drawing.Size(230, 30);
            this.buttonDateTime.TabIndex = 4;
            this.buttonDateTime.Value = new System.DateTime(2019, 4, 14, 0, 0, 0, 0);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowAll.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowAll.Location = new System.Drawing.Point(32, 284);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(93, 33);
            this.buttonShowAll.TabIndex = 2;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseCustomBackColor = true;
            this.buttonShowAll.UseCustomForeColor = true;
            this.buttonShowAll.UseSelectable = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenu.BackgroundImage")));
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(40, 32);
            this.buttonMenu.TabIndex = 7;
            this.buttonMenu.UseCustomBackColor = true;
            this.buttonMenu.UseCustomForeColor = true;
            this.buttonMenu.UseSelectable = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(23, 74);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(160, 50);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome ,";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(209, 284);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 33);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseCustomBackColor = true;
            this.buttonSearch.UseCustomForeColor = true;
            this.buttonSearch.UseSelectable = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textSearch
            // 
            // 
            // 
            // 
            this.textSearch.CustomButton.Image = null;
            this.textSearch.CustomButton.Location = new System.Drawing.Point(247, 2);
            this.textSearch.CustomButton.Name = "";
            this.textSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSearch.CustomButton.TabIndex = 1;
            this.textSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSearch.CustomButton.UseSelectable = true;
            this.textSearch.CustomButton.Visible = false;
            this.textSearch.Lines = new string[0];
            this.textSearch.Location = new System.Drawing.Point(32, 226);
            this.textSearch.MaxLength = 32767;
            this.textSearch.Name = "textSearch";
            this.textSearch.PasswordChar = '\0';
            this.textSearch.PromptText = "Search";
            this.textSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSearch.SelectedText = "";
            this.textSearch.SelectionLength = 0;
            this.textSearch.SelectionStart = 0;
            this.textSearch.ShortcutsEnabled = true;
            this.textSearch.Size = new System.Drawing.Size(273, 28);
            this.textSearch.TabIndex = 1;
            this.textSearch.UseSelectable = true;
            this.textSearch.WaterMark = "Search";
            this.textSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.Transparent;
            this.buttonBook.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBook.Location = new System.Drawing.Point(32, 423);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(273, 62);
            this.buttonBook.TabIndex = 5;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseCustomBackColor = true;
            this.buttonBook.UseCustomForeColor = true;
            this.buttonBook.UseSelectable = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.historyToolStripMenuItem1,
            this.logOutToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(130, 76);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.historyToolStripMenuItem1.Text = "History";
            this.historyToolStripMenuItem1.Click += new System.EventHandler(this.historyToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panelCustomerHome2
            // 
            this.panelCustomerHome2.BackColor = System.Drawing.Color.Aquamarine;
            this.panelCustomerHome2.Controls.Add(this.gridCustomerHome);
            this.panelCustomerHome2.HorizontalScrollbarBarColor = true;
            this.panelCustomerHome2.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCustomerHome2.HorizontalScrollbarSize = 10;
            this.panelCustomerHome2.Location = new System.Drawing.Point(344, 38);
            this.panelCustomerHome2.Name = "panelCustomerHome2";
            this.panelCustomerHome2.Size = new System.Drawing.Size(727, 750);
            this.panelCustomerHome2.TabIndex = 7;
            this.panelCustomerHome2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panelCustomerHome2.UseCustomBackColor = true;
            this.panelCustomerHome2.UseCustomForeColor = true;
            this.panelCustomerHome2.VerticalScrollbarBarColor = true;
            this.panelCustomerHome2.VerticalScrollbarHighlightOnWheel = false;
            this.panelCustomerHome2.VerticalScrollbarSize = 10;
            // 
            // gridCustomerHome
            // 
            this.gridCustomerHome.AllowUserToAddRows = false;
            this.gridCustomerHome.AllowUserToDeleteRows = false;
            this.gridCustomerHome.AllowUserToResizeColumns = false;
            this.gridCustomerHome.AllowUserToResizeRows = false;
            this.gridCustomerHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomerHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridCustomerHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCustomerHome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCustomerHome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomerHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCustomerHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCustomerHome.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridCustomerHome.EnableHeadersVisualStyles = false;
            this.gridCustomerHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCustomerHome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCustomerHome.Location = new System.Drawing.Point(81, 0);
            this.gridCustomerHome.Name = "gridCustomerHome";
            this.gridCustomerHome.ReadOnly = true;
            this.gridCustomerHome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCustomerHome.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCustomerHome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCustomerHome.RowTemplate.Height = 24;
            this.gridCustomerHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomerHome.Size = new System.Drawing.Size(638, 742);
            this.gridCustomerHome.TabIndex = 2;
            this.gridCustomerHome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomerHome_CellContentClick);
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 779);
            this.Controls.Add(this.panelCustomerHome);
            this.Controls.Add(this.panelCustomerHome2);
            this.MaximizeBox = false;
            this.Name = "CustomerHome";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelCustomerHome.ResumeLayout(false);
            this.panelCustomerHome.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.panelCustomerHome2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelCustomerHome;
        private System.Windows.Forms.Label labelWelcome;
        private MetroFramework.Controls.MetroButton buttonSearch;
        private MetroFramework.Controls.MetroTextBox textSearch;
        private MetroFramework.Controls.MetroButton buttonBook;
        private MetroFramework.Controls.MetroButton buttonMenu;
        private MetroFramework.Controls.MetroContextMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel panelCustomerHome2;
        private MetroFramework.Controls.MetroGrid gridCustomerHome;
        private MetroFramework.Controls.MetroButton buttonShowAll;
        private MetroFramework.Controls.MetroDateTime buttonDateTime;
        private System.Windows.Forms.Label labelShowName;
        private System.Windows.Forms.Label labelShow;
        private MetroFramework.Controls.MetroButton buttonInvoice;
    }
}