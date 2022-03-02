
namespace GalleryApp
{
    partial class Form1
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
            System.Windows.Forms.Label image_idLabel;
            System.Windows.Forms.Label image_nameLabel;
            System.Windows.Forms.Label image_pathLabel;
            System.Windows.Forms.Label imgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.galleryAppDataSet1 = new GalleryApp.GalleryAppDataSet1();
            this.imagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagesTableAdapter = new GalleryApp.GalleryAppDataSet1TableAdapters.ImagesTableAdapter();
            this.tableAdapterManager = new GalleryApp.GalleryAppDataSet1TableAdapters.TableAdapterManager();
            this.imagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.image_idLabel1 = new System.Windows.Forms.Label();
            this.image_nameTextBox = new System.Windows.Forms.TextBox();
            this.image_pathLabel1 = new System.Windows.Forms.Label();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            image_idLabel = new System.Windows.Forms.Label();
            image_nameLabel = new System.Windows.Forms.Label();
            image_pathLabel = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.galleryAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingNavigator)).BeginInit();
            this.imagesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // image_idLabel
            // 
            image_idLabel.AutoSize = true;
            image_idLabel.Location = new System.Drawing.Point(79, 88);
            image_idLabel.Name = "image_idLabel";
            image_idLabel.Size = new System.Drawing.Size(49, 13);
            image_idLabel.TabIndex = 10;
            image_idLabel.Text = "image id:";
            // 
            // image_nameLabel
            // 
            image_nameLabel.AutoSize = true;
            image_nameLabel.Location = new System.Drawing.Point(79, 117);
            image_nameLabel.Name = "image_nameLabel";
            image_nameLabel.Size = new System.Drawing.Size(67, 13);
            image_nameLabel.TabIndex = 12;
            image_nameLabel.Text = "image name:";
            // 
            // image_pathLabel
            // 
            image_pathLabel.AutoSize = true;
            image_pathLabel.Location = new System.Drawing.Point(79, 137);
            image_pathLabel.Name = "image_pathLabel";
            image_pathLabel.Size = new System.Drawing.Size(62, 13);
            image_pathLabel.TabIndex = 14;
            image_pathLabel.Text = "image path:";
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Location = new System.Drawing.Point(79, 163);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(26, 13);
            imgLabel.TabIndex = 16;
            imgLabel.Text = "img:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(372, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(108, 264);
            this.listBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Images";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // galleryAppDataSet1
            // 
            this.galleryAppDataSet1.DataSetName = "GalleryAppDataSet1";
            this.galleryAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagesBindingSource
            // 
            this.imagesBindingSource.DataMember = "Images";
            this.imagesBindingSource.DataSource = this.galleryAppDataSet1;
            // 
            // imagesTableAdapter
            // 
            this.imagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImagesTableAdapter = this.imagesTableAdapter;
            this.tableAdapterManager.UpdateOrder = GalleryApp.GalleryAppDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagesBindingNavigator
            // 
            this.imagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imagesBindingNavigator.BindingSource = this.imagesBindingSource;
            this.imagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.imagesBindingNavigatorSaveItem});
            this.imagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imagesBindingNavigator.Name = "imagesBindingNavigator";
            this.imagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imagesBindingNavigator.Size = new System.Drawing.Size(636, 25);
            this.imagesBindingNavigator.TabIndex = 10;
            this.imagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // imagesBindingNavigatorSaveItem
            // 
            this.imagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imagesBindingNavigatorSaveItem.Image")));
            this.imagesBindingNavigatorSaveItem.Name = "imagesBindingNavigatorSaveItem";
            this.imagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.imagesBindingNavigatorSaveItem.Text = "Save Data";
            this.imagesBindingNavigatorSaveItem.Click += new System.EventHandler(this.imagesBindingNavigatorSaveItem_Click);
            // 
            // image_idLabel1
            // 
            this.image_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagesBindingSource, "image_id", true));
            this.image_idLabel1.Location = new System.Drawing.Point(152, 88);
            this.image_idLabel1.Name = "image_idLabel1";
            this.image_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.image_idLabel1.TabIndex = 11;
            this.image_idLabel1.Text = "label1";
            // 
            // image_nameTextBox
            // 
            this.image_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagesBindingSource, "image_name", true));
            this.image_nameTextBox.Location = new System.Drawing.Point(152, 114);
            this.image_nameTextBox.Name = "image_nameTextBox";
            this.image_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.image_nameTextBox.TabIndex = 13;
            // 
            // image_pathLabel1
            // 
            this.image_pathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imagesBindingSource, "image_path", true));
            this.image_pathLabel1.Location = new System.Drawing.Point(152, 137);
            this.image_pathLabel1.Name = "image_pathLabel1";
            this.image_pathLabel1.Size = new System.Drawing.Size(214, 23);
            this.image_pathLabel1.TabIndex = 15;
            this.image_pathLabel1.Text = "label1";
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.imagesBindingSource, "img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(152, 163);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(150, 150);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 17;
            this.imgPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.image_idLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(image_idLabel);
            this.Controls.Add(image_nameLabel);
            this.Controls.Add(this.image_nameTextBox);
            this.Controls.Add(image_pathLabel);
            this.Controls.Add(this.image_pathLabel1);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.imagesBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.galleryAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesBindingNavigator)).EndInit();
            this.imagesBindingNavigator.ResumeLayout(false);
            this.imagesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private GalleryAppDataSet1 galleryAppDataSet1;
        private System.Windows.Forms.BindingSource imagesBindingSource;
        private GalleryAppDataSet1TableAdapters.ImagesTableAdapter imagesTableAdapter;
        private GalleryAppDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imagesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton imagesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label image_idLabel1;
        private System.Windows.Forms.TextBox image_nameTextBox;
        private System.Windows.Forms.Label image_pathLabel1;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

