namespace AutomationUI.Forms.StockForms
{
    partial class StockCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCardForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnStockCode = new DevExpress.XtraEditors.ButtonEdit();
            this.pictureEditStock = new AutomationUI.UserControls.Controls.MyPictureEdit();
            this.txtStockName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblStockName = new DevExpress.XtraEditors.LabelControl();
            this.lblStockCode = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.txtSaleVAT = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.txtPurchaseVat = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblSaleVAT = new DevExpress.XtraEditors.LabelControl();
            this.lblPurchaseVAT = new DevExpress.XtraEditors.LabelControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.txtSalePrice = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblSalePrice = new DevExpress.XtraEditors.LabelControl();
            this.txtPurchasePrice = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblPurchasePrice = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtStockBarcode = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbStockUnit = new AutomationUI.UserControls.Controls.MyComboBoxEdit();
            this.lblUnit = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtGroupName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.btnGroupCode = new AutomationUI.UserControls.Controls.MyButtonEdit();
            this.lblGroupName = new DevExpress.XtraEditors.LabelControl();
            this.lblGroupCode = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStockUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroupCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnStockCode);
            this.groupControl1.Controls.Add(this.pictureEditStock);
            this.groupControl1.Controls.Add(this.txtStockName);
            this.groupControl1.Controls.Add(this.lblStockName);
            this.groupControl1.Controls.Add(this.lblStockCode);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(747, 142);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Main Stock Information";
            // 
            // btnStockCode
            // 
            this.btnStockCode.Location = new System.Drawing.Point(121, 59);
            this.btnStockCode.Name = "btnStockCode";
            this.btnStockCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnStockCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnStockCode.Size = new System.Drawing.Size(228, 20);
            this.btnStockCode.TabIndex = 3;
            this.btnStockCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnStockCode_ButtonClick);
            // 
            // pictureEditStock
            // 
            this.pictureEditStock.EnterMoveNextControl = true;
            this.pictureEditStock.Location = new System.Drawing.Point(377, 29);
            this.pictureEditStock.Name = "pictureEditStock";
            this.pictureEditStock.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.pictureEditStock.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEditStock.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.pictureEditStock.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.pictureEditStock.Properties.NullText = "No Picture";
            this.pictureEditStock.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditStock.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditStock.Size = new System.Drawing.Size(100, 100);
            this.pictureEditStock.TabIndex = 2;
            // 
            // txtStockName
            // 
            this.txtStockName.EnterMoveNextControl = true;
            this.txtStockName.Location = new System.Drawing.Point(121, 84);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtStockName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtStockName.Properties.MaxLength = 50;
            this.txtStockName.Size = new System.Drawing.Size(228, 20);
            this.txtStockName.TabIndex = 1;
            // 
            // lblStockName
            // 
            this.lblStockName.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblStockName.Appearance.Options.UseForeColor = true;
            this.lblStockName.Location = new System.Drawing.Point(40, 91);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(56, 13);
            this.lblStockName.TabIndex = 1;
            this.lblStockName.Text = "Stock Name";
            // 
            // lblStockCode
            // 
            this.lblStockCode.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblStockCode.Appearance.Options.UseForeColor = true;
            this.lblStockCode.Location = new System.Drawing.Point(40, 62);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(54, 13);
            this.lblStockCode.TabIndex = 0;
            this.lblStockCode.Text = "Stock Code";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl7);
            this.groupControl2.Controls.Add(this.groupControl6);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 142);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(747, 258);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "General Stock Information";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.txtSaleVAT);
            this.groupControl7.Controls.Add(this.txtPurchaseVat);
            this.groupControl7.Controls.Add(this.lblSaleVAT);
            this.groupControl7.Controls.Add(this.lblPurchaseVAT);
            this.groupControl7.Location = new System.Drawing.Point(378, 140);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(364, 108);
            this.groupControl7.TabIndex = 3;
            this.groupControl7.Text = "VAT Information %";
            // 
            // txtSaleVAT
            // 
            this.txtSaleVAT.EnterMoveNextControl = true;
            this.txtSaleVAT.Location = new System.Drawing.Point(107, 68);
            this.txtSaleVAT.Name = "txtSaleVAT";
            this.txtSaleVAT.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSaleVAT.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSaleVAT.Properties.MaxLength = 50;
            this.txtSaleVAT.Size = new System.Drawing.Size(218, 20);
            this.txtSaleVAT.TabIndex = 1;
            // 
            // txtPurchaseVat
            // 
            this.txtPurchaseVat.EnterMoveNextControl = true;
            this.txtPurchaseVat.Location = new System.Drawing.Point(107, 38);
            this.txtPurchaseVat.Name = "txtPurchaseVat";
            this.txtPurchaseVat.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPurchaseVat.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPurchaseVat.Properties.MaxLength = 50;
            this.txtPurchaseVat.Size = new System.Drawing.Size(218, 20);
            this.txtPurchaseVat.TabIndex = 0;
            // 
            // lblSaleVAT
            // 
            this.lblSaleVAT.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblSaleVAT.Appearance.Options.UseForeColor = true;
            this.lblSaleVAT.Location = new System.Drawing.Point(13, 75);
            this.lblSaleVAT.Name = "lblSaleVAT";
            this.lblSaleVAT.Size = new System.Drawing.Size(42, 13);
            this.lblSaleVAT.TabIndex = 1;
            this.lblSaleVAT.Text = "Sale VAT";
            // 
            // lblPurchaseVAT
            // 
            this.lblPurchaseVAT.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblPurchaseVAT.Appearance.Options.UseForeColor = true;
            this.lblPurchaseVAT.Location = new System.Drawing.Point(13, 45);
            this.lblPurchaseVAT.Name = "lblPurchaseVAT";
            this.lblPurchaseVAT.Size = new System.Drawing.Size(66, 13);
            this.lblPurchaseVAT.TabIndex = 0;
            this.lblPurchaseVAT.Text = "Purchase VAT";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.txtSalePrice);
            this.groupControl6.Controls.Add(this.lblSalePrice);
            this.groupControl6.Controls.Add(this.txtPurchasePrice);
            this.groupControl6.Controls.Add(this.lblPurchasePrice);
            this.groupControl6.Location = new System.Drawing.Point(378, 26);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(364, 108);
            this.groupControl6.TabIndex = 2;
            this.groupControl6.Text = "Price Information";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.EnterMoveNextControl = true;
            this.txtSalePrice.Location = new System.Drawing.Point(107, 68);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSalePrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSalePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSalePrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtSalePrice.Properties.MaskSettings.Set("mask", "c");
            this.txtSalePrice.Properties.MaxLength = 50;
            this.txtSalePrice.Size = new System.Drawing.Size(218, 20);
            this.txtSalePrice.TabIndex = 1;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblSalePrice.Appearance.Options.UseForeColor = true;
            this.lblSalePrice.Location = new System.Drawing.Point(13, 71);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(46, 13);
            this.lblSalePrice.TabIndex = 2;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.EnterMoveNextControl = true;
            this.txtPurchasePrice.Location = new System.Drawing.Point(107, 38);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPurchasePrice.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPurchasePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPurchasePrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPurchasePrice.Properties.MaskSettings.Set("mask", "c");
            this.txtPurchasePrice.Properties.MaxLength = 50;
            this.txtPurchasePrice.Size = new System.Drawing.Size(218, 20);
            this.txtPurchasePrice.TabIndex = 0;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblPurchasePrice.Appearance.Options.UseForeColor = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(13, 40);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(70, 13);
            this.lblPurchasePrice.TabIndex = 0;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtStockBarcode);
            this.groupControl5.Controls.Add(this.labelControl1);
            this.groupControl5.Controls.Add(this.cmbStockUnit);
            this.groupControl5.Controls.Add(this.lblUnit);
            this.groupControl5.Location = new System.Drawing.Point(5, 140);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(364, 108);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Unit and Barcode";
            // 
            // txtStockBarcode
            // 
            this.txtStockBarcode.EnterMoveNextControl = true;
            this.txtStockBarcode.Location = new System.Drawing.Point(93, 71);
            this.txtStockBarcode.Name = "txtStockBarcode";
            this.txtStockBarcode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtStockBarcode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtStockBarcode.Properties.MaxLength = 50;
            this.txtStockBarcode.Size = new System.Drawing.Size(228, 20);
            this.txtStockBarcode.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Barcode";
            // 
            // cmbStockUnit
            // 
            this.cmbStockUnit.EditValue = "Number";
            this.cmbStockUnit.EnterMoveNextControl = true;
            this.cmbStockUnit.Location = new System.Drawing.Point(93, 41);
            this.cmbStockUnit.Name = "cmbStockUnit";
            this.cmbStockUnit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.cmbStockUnit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cmbStockUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStockUnit.Properties.Items.AddRange(new object[] {
            "Number",
            "Piece",
            "Kilo",
            "Metre"});
            this.cmbStockUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbStockUnit.Size = new System.Drawing.Size(228, 20);
            this.cmbStockUnit.TabIndex = 0;
            // 
            // lblUnit
            // 
            this.lblUnit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblUnit.Appearance.Options.UseForeColor = true;
            this.lblUnit.Location = new System.Drawing.Point(12, 45);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(48, 13);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "Stock Unit";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtGroupName);
            this.groupControl4.Controls.Add(this.btnGroupCode);
            this.groupControl4.Controls.Add(this.lblGroupName);
            this.groupControl4.Controls.Add(this.lblGroupCode);
            this.groupControl4.Location = new System.Drawing.Point(5, 26);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(364, 108);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Stock Group";
            // 
            // txtGroupName
            // 
            this.txtGroupName.EnterMoveNextControl = true;
            this.txtGroupName.Location = new System.Drawing.Point(93, 68);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtGroupName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGroupName.Properties.MaxLength = 50;
            this.txtGroupName.Size = new System.Drawing.Size(228, 20);
            this.txtGroupName.TabIndex = 1;
            // 
            // btnGroupCode
            // 
            this.btnGroupCode.EnterMoveNextControl = true;
            this.btnGroupCode.Location = new System.Drawing.Point(93, 38);
            this.btnGroupCode.Name = "btnGroupCode";
            this.btnGroupCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnGroupCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnGroupCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnGroupCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnGroupCode.Size = new System.Drawing.Size(228, 20);
            this.btnGroupCode.TabIndex = 0;
            this.btnGroupCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnGroupCode_ButtonClick);
            // 
            // lblGroupName
            // 
            this.lblGroupName.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblGroupName.Appearance.Options.UseForeColor = true;
            this.lblGroupName.Location = new System.Drawing.Point(12, 71);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(59, 13);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Group Name";
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblGroupCode.Appearance.Options.UseForeColor = true;
            this.lblGroupCode.Location = new System.Drawing.Point(13, 40);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(57, 13);
            this.lblGroupCode.TabIndex = 0;
            this.lblGroupCode.Text = "Group Code";
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.btnExit);
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Controls.Add(this.btnUpdate);
            this.groupControl3.Controls.Add(this.btnSave);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 400);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(747, 53);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "groupControl3";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(645, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(548, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(452, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 41);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(354, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StockCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 453);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("StockCardForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Card";
            this.Load += new System.EventHandler(this.StockCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStockUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroupCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private UserControls.Controls.MySimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl lblStockName;
        private DevExpress.XtraEditors.LabelControl lblStockCode;
        private UserControls.Controls.MyTextEdit txtStockName;
        private UserControls.Controls.MyButtonEdit btnGroupCode;
        private DevExpress.XtraEditors.LabelControl lblGroupName;
        private DevExpress.XtraEditors.LabelControl lblGroupCode;
        private UserControls.Controls.MyTextEdit txtGroupName;
        private UserControls.Controls.MyTextEdit txtStockBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Controls.MyComboBoxEdit cmbStockUnit;
        private DevExpress.XtraEditors.LabelControl lblUnit;
        private UserControls.Controls.MyTextEdit txtSalePrice;
        private DevExpress.XtraEditors.LabelControl lblSalePrice;
        private UserControls.Controls.MyTextEdit txtPurchasePrice;
        private DevExpress.XtraEditors.LabelControl lblPurchasePrice;
        private UserControls.Controls.MyTextEdit txtSaleVAT;
        private UserControls.Controls.MyTextEdit txtPurchaseVat;
        private DevExpress.XtraEditors.LabelControl lblSaleVAT;
        private DevExpress.XtraEditors.LabelControl lblPurchaseVAT;
        private UserControls.Controls.MyPictureEdit pictureEditStock;
        private DevExpress.XtraEditors.ButtonEdit btnStockCode;
    }
}