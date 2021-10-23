
namespace TP03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnVid = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtbx_pays = new System.Windows.Forms.TextBox();
            this.txtbx_nom = new System.Windows.Forms.TextBox();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_rech = new System.Windows.Forms.Button();
            this.btn_rechSlct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rechSlct);
            this.groupBox1.Controls.Add(this.btn_rech);
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.btnSup);
            this.groupBox1.Controls.Add(this.btnVid);
            this.groupBox1.Controls.Add(this.btnQuit);
            this.groupBox1.Controls.Add(this.txtbx_pays);
            this.groupBox1.Controls.Add(this.txtbx_nom);
            this.groupBox1.Controls.Add(this.txtbx_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAjt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise a jour Ville";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(250, 52);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(107, 31);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(250, 88);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(107, 31);
            this.btnSup.TabIndex = 5;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnVid
            // 
            this.btnVid.Location = new System.Drawing.Point(8, 177);
            this.btnVid.Name = "btnVid";
            this.btnVid.Size = new System.Drawing.Size(94, 33);
            this.btnVid.TabIndex = 6;
            this.btnVid.Text = "Vider";
            this.btnVid.UseVisualStyleBackColor = true;
            this.btnVid.Click += new System.EventHandler(this.btnVid_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(117, 177);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 33);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtbx_pays
            // 
            this.txtbx_pays.Location = new System.Drawing.Point(65, 128);
            this.txtbx_pays.Name = "txtbx_pays";
            this.txtbx_pays.Size = new System.Drawing.Size(130, 20);
            this.txtbx_pays.TabIndex = 5;
            // 
            // txtbx_nom
            // 
            this.txtbx_nom.Location = new System.Drawing.Point(65, 85);
            this.txtbx_nom.Name = "txtbx_nom";
            this.txtbx_nom.Size = new System.Drawing.Size(130, 20);
            this.txtbx_nom.TabIndex = 4;
            // 
            // txtbx_id
            // 
            this.txtbx_id.Location = new System.Drawing.Point(65, 46);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(130, 20);
            this.txtbx_id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pays: ";
            // 
            // btnAjt
            // 
            this.btnAjt.Location = new System.Drawing.Point(250, 15);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(107, 31);
            this.btnAjt.TabIndex = 3;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = true;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(397, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 223);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste Villes: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_rech
            // 
            this.btn_rech.Location = new System.Drawing.Point(250, 125);
            this.btn_rech.Name = "btn_rech";
            this.btn_rech.Size = new System.Drawing.Size(107, 32);
            this.btn_rech.TabIndex = 8;
            this.btn_rech.Text = "Rechercher";
            this.btn_rech.UseVisualStyleBackColor = true;
            this.btn_rech.Click += new System.EventHandler(this.btn_rech_Click);
            // 
            // btn_rechSlct
            // 
            this.btn_rechSlct.Location = new System.Drawing.Point(250, 163);
            this.btn_rechSlct.Name = "btn_rechSlct";
            this.btn_rechSlct.Size = new System.Drawing.Size(107, 32);
            this.btn_rechSlct.TabIndex = 9;
            this.btn_rechSlct.Text = "Rech&Select";
            this.btn_rechSlct.UseVisualStyleBackColor = true;
            this.btn_rechSlct.Click += new System.EventHandler(this.btn_rechSlct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TP03";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnVid;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtbx_pays;
        private System.Windows.Forms.TextBox txtbx_nom;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_rech;
        private System.Windows.Forms.Button btn_rechSlct;
    }
}

