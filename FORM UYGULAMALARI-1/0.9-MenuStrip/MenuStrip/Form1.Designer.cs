namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aasdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maceraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paunVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.esaretiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.johnWickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incirReçeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzüklerinEfendisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepİvedikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip5
            // 
            this.menuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.aasdasdToolStripMenuItem,
            this.maceraToolStripMenuItem,
            this.komediToolStripMenuItem,
            this.paunVerToolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(622, 36);
            this.menuStrip5.TabIndex = 4;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esaretiToolStripMenuItem,
            this.johnWickToolStripMenuItem});
            this.asdToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.asdToolStripMenuItem.Text = "Aksiyon";
            // 
            // aasdasdToolStripMenuItem
            // 
            this.aasdasdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incirReçeliToolStripMenuItem});
            this.aasdasdToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aasdasdToolStripMenuItem.Name = "aasdasdToolStripMenuItem";
            this.aasdasdToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.aasdasdToolStripMenuItem.Text = "Romantik";
            // 
            // maceraToolStripMenuItem
            // 
            this.maceraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yüzüklerinEfendisiToolStripMenuItem,
            this.duneToolStripMenuItem});
            this.maceraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maceraToolStripMenuItem.Name = "maceraToolStripMenuItem";
            this.maceraToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
            this.maceraToolStripMenuItem.Text = "Macera";
            // 
            // komediToolStripMenuItem
            // 
            this.komediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepİvedikToolStripMenuItem,
            this.goraToolStripMenuItem});
            this.komediToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.komediToolStripMenuItem.Name = "komediToolStripMenuItem";
            this.komediToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.komediToolStripMenuItem.Text = "Komedi";
            // 
            // paunVerToolStripMenuItem
            // 
            this.paunVerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.paunVerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paunVerToolStripMenuItem.Name = "paunVerToolStripMenuItem";
            this.paunVerToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.paunVerToolStripMenuItem.Text = "Paun Ver";
            this.paunVerToolStripMenuItem.Click += new System.EventHandler(this.paunVerToolStripMenuItem_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            // 
            // esaretiToolStripMenuItem
            // 
            this.esaretiToolStripMenuItem.Name = "esaretiToolStripMenuItem";
            this.esaretiToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.esaretiToolStripMenuItem.Text = "Hızkı Ve Öfkeli";
            this.esaretiToolStripMenuItem.Click += new System.EventHandler(this.esaretiToolStripMenuItem_Click);
            // 
            // johnWickToolStripMenuItem
            // 
            this.johnWickToolStripMenuItem.Name = "johnWickToolStripMenuItem";
            this.johnWickToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.johnWickToolStripMenuItem.Text = "John Wick";
            // 
            // incirReçeliToolStripMenuItem
            // 
            this.incirReçeliToolStripMenuItem.Name = "incirReçeliToolStripMenuItem";
            this.incirReçeliToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.incirReçeliToolStripMenuItem.Text = "İncir Reçeli";
            // 
            // yüzüklerinEfendisiToolStripMenuItem
            // 
            this.yüzüklerinEfendisiToolStripMenuItem.Name = "yüzüklerinEfendisiToolStripMenuItem";
            this.yüzüklerinEfendisiToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.yüzüklerinEfendisiToolStripMenuItem.Text = "Yüzüklerin Efendisi";
            // 
            // duneToolStripMenuItem
            // 
            this.duneToolStripMenuItem.Name = "duneToolStripMenuItem";
            this.duneToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.duneToolStripMenuItem.Text = "Dune";
            // 
            // recepİvedikToolStripMenuItem
            // 
            this.recepİvedikToolStripMenuItem.Name = "recepİvedikToolStripMenuItem";
            this.recepİvedikToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.recepİvedikToolStripMenuItem.Text = "Recep İvedik";
            // 
            // goraToolStripMenuItem
            // 
            this.goraToolStripMenuItem.Name = "goraToolStripMenuItem";
            this.goraToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.goraToolStripMenuItem.Text = "Gora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(250, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(275, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(250, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aasdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esaretiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maceraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paunVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem johnWickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incirReçeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzüklerinEfendisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepİvedikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goraToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

