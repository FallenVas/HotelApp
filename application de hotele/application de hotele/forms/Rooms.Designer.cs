
namespace application_de_hotele.forms
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.titlePic = new System.Windows.Forms.PictureBox();
            this.GridData = new System.Windows.Forms.DataGridView();
            this.customImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderPanel.BackgroundImage")));
            this.HeaderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeaderPanel.BorderRadius = 1;
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.titleLbl);
            this.HeaderPanel.Controls.Add(this.titlePic);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.HeaderPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.HeaderPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.HeaderPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Quality = 10;
            this.HeaderPanel.Size = new System.Drawing.Size(1016, 47);
            this.HeaderPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::application_de_hotele.Properties.Resources.back_240px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(979, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Silver;
            this.titleLbl.Location = new System.Drawing.Point(125, 12);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(80, 25);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "ROOMS";
            // 
            // titlePic
            // 
            this.titlePic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.titlePic.Enabled = false;
            this.titlePic.Image = global::application_de_hotele.Properties.Resources.house_240px;
            this.titlePic.Location = new System.Drawing.Point(74, 3);
            this.titlePic.Name = "titlePic";
            this.titlePic.Size = new System.Drawing.Size(49, 41);
            this.titlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlePic.TabIndex = 0;
            this.titlePic.TabStop = false;
            // 
            // GridData
            // 
            this.GridData.AllowUserToAddRows = false;
            this.GridData.AllowUserToDeleteRows = false;
            this.GridData.AllowUserToOrderColumns = true;
            this.GridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.GridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.GridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(24)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridData.ColumnHeadersHeight = 40;
            this.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customImage,
            this.ID,
            this.roomType,
            this.roomPrice});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridData.DefaultCellStyle = dataGridViewCellStyle9;
            this.GridData.EnableHeadersVisualStyles = false;
            this.GridData.Location = new System.Drawing.Point(12, 65);
            this.GridData.Name = "GridData";
            this.GridData.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridData.RowHeadersVisible = false;
            this.GridData.RowTemplate.Height = 50;
            this.GridData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridData.Size = new System.Drawing.Size(921, 523);
            this.GridData.TabIndex = 3;
            this.GridData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridData_RowsAdded);
            this.GridData.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridData_RowsRemoved);
            // 
            // customImage
            // 
            this.customImage.FillWeight = 20F;
            this.customImage.HeaderText = "";
            this.customImage.Name = "customImage";
            this.customImage.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idRoom";
            this.ID.FillWeight = 70F;
            this.ID.HeaderText = "Room Number";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // roomType
            // 
            this.roomType.DataPropertyName = "roomType";
            this.roomType.HeaderText = "Room Type";
            this.roomType.Name = "roomType";
            this.roomType.ReadOnly = true;
            // 
            // roomPrice
            // 
            this.roomPrice.DataPropertyName = "roomPrice";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = "0";
            this.roomPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.roomPrice.HeaderText = "Room Price";
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.ReadOnly = true;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = null;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(948, 110);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(60)))));
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(17, 478);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 4;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 47;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            this.bunifuVScrollBar1.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.bunifuVScrollBar1_Scroll);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "house_240px.png");
            this.imageList1.Images.SetKeyName(1, "checkmark_512px.png");
            this.imageList1.Images.SetKeyName(2, "cancel_96px.png");
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = false;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = false;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1016, 600);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.GridData);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel HeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox titlePic;
        private System.Windows.Forms.DataGridView GridData;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn customImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPrice;
    }
}