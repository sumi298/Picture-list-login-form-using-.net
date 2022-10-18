namespace loginpicturelist
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PbX = new System.Windows.Forms.PictureBox();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PbX
            // 
            this.PbX.Location = new System.Drawing.Point(127, 53);
            this.PbX.Name = "PbX";
            this.PbX.Size = new System.Drawing.Size(256, 256);
            this.PbX.TabIndex = 0;
            this.PbX.TabStop = false;
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Enabled = true;
            this.tmrChangeImage.Interval = 1300;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "FB_IMG_1664086827025[1].jpg");
            this.imageList.Images.SetKeyName(1, "IMG_20220919_001139[1].jpg");
            this.imageList.Images.SetKeyName(2, "IMG_20221008_205502[1].jpg");
            this.imageList.Images.SetKeyName(3, "IMG_20221008_213635[1].jpg");
            this.imageList.Images.SetKeyName(4, "IMG_20221008_214031[1].jpg");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(462, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "ExitImg";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(787, 426);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbX;
        private System.Windows.Forms.Timer tmrChangeImage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}