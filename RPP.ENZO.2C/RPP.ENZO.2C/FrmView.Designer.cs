namespace RPP.ENZO._2C
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            listBox1=new ListBox();
            label1=new Label();
            comboBox1=new ComboBox();
            pictureBox1=new PictureBox();
            btnFabricar=new Button();
            btnEliminar=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=15;
            listBox1.Location=new Point(12, 11);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(547, 424);
            listBox1.TabIndex=0;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(602, 20);
            label1.Name="label1";
            label1.Size=new Size(152, 21);
            label1.TabIndex=1;
            label1.Text="Tipos de Vehiculos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(582, 44);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(206, 23);
            comboBox1.TabIndex=2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(602, 93);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(152, 149);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=3;
            pictureBox1.TabStop=false;
            // 
            // btnFabricar
            // 
            btnFabricar.Location=new Point(602, 274);
            btnFabricar.Name="btnFabricar";
            btnFabricar.Size=new Size(152, 39);
            btnFabricar.TabIndex=4;
            btnFabricar.Text="Fabricar";
            btnFabricar.UseVisualStyleBackColor=true;
            btnFabricar.Click+=btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location=new Point(602, 335);
            btnEliminar.Name="btnEliminar";
            btnEliminar.Size=new Size(152, 38);
            btnEliminar.TabIndex=5;
            btnEliminar.Text="Eliminar";
            btnEliminar.UseVisualStyleBackColor=true;
            btnEliminar.Click+=btnEliminar_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="FrmView";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button btnFabricar;
        private Button btnEliminar;
    }
}