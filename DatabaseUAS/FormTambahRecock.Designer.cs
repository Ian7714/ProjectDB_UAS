namespace DesainUI
{
    partial class FormTambahRecock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTglPercobaan = new System.Windows.Forms.DateTimePicker();
            this.comboBoxResep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonBerhasil = new System.Windows.Forms.RadioButton();
            this.radioButtonGagal = new System.Windows.Forms.RadioButton();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "Tanggal Percobaan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Resep";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSimpan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(332, 238);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 49);
            this.btnSimpan.TabIndex = 67;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBatal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(4, 238);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(148, 49);
            this.btnBatal.TabIndex = 66;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-177, -4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(832, 44);
            this.label3.TabIndex = 65;
            this.label3.Text = "TAMBAH RECOCK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerTglPercobaan
            // 
            this.dateTimePickerTglPercobaan.Location = new System.Drawing.Point(199, 114);
            this.dateTimePickerTglPercobaan.Name = "dateTimePickerTglPercobaan";
            this.dateTimePickerTglPercobaan.Size = new System.Drawing.Size(206, 22);
            this.dateTimePickerTglPercobaan.TabIndex = 72;
            // 
            // comboBoxResep
            // 
            this.comboBoxResep.FormattingEnabled = true;
            this.comboBoxResep.Location = new System.Drawing.Point(199, 73);
            this.comboBoxResep.Name = "comboBoxResep";
            this.comboBoxResep.Size = new System.Drawing.Size(206, 24);
            this.comboBoxResep.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Hasil Percobaan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "Rating";
            // 
            // radioButtonBerhasil
            // 
            this.radioButtonBerhasil.AutoSize = true;
            this.radioButtonBerhasil.Location = new System.Drawing.Point(199, 152);
            this.radioButtonBerhasil.Name = "radioButtonBerhasil";
            this.radioButtonBerhasil.Size = new System.Drawing.Size(77, 20);
            this.radioButtonBerhasil.TabIndex = 76;
            this.radioButtonBerhasil.TabStop = true;
            this.radioButtonBerhasil.Text = "Berhasil";
            this.radioButtonBerhasil.UseVisualStyleBackColor = true;
            // 
            // radioButtonGagal
            // 
            this.radioButtonGagal.AutoSize = true;
            this.radioButtonGagal.Location = new System.Drawing.Point(307, 152);
            this.radioButtonGagal.Name = "radioButtonGagal";
            this.radioButtonGagal.Size = new System.Drawing.Size(65, 20);
            this.radioButtonGagal.TabIndex = 77;
            this.radioButtonGagal.TabStop = true;
            this.radioButtonGagal.Text = "Gagal";
            this.radioButtonGagal.UseVisualStyleBackColor = true;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(199, 193);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(206, 24);
            this.comboBoxRating.TabIndex = 78;
            // 
            // FormTambahRecock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 316);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.radioButtonGagal);
            this.Controls.Add(this.radioButtonBerhasil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxResep);
            this.Controls.Add(this.dateTimePickerTglPercobaan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label3);
            this.Name = "FormTambahRecock";
            this.Text = "Form Tambah Recock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglPercobaan;
        private System.Windows.Forms.ComboBox comboBoxResep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonBerhasil;
        private System.Windows.Forms.RadioButton radioButtonGagal;
        private System.Windows.Forms.ComboBox comboBoxRating;
    }
}