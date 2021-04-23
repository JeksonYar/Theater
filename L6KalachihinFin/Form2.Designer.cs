namespace L6KalachihinFin
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playintheateridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wishgoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_play_finDataSet7 = new L6KalachihinFin.bd_play_finDataSet7();
            this.peopleTableAdapter = new L6KalachihinFin.bd_play_finDataSet7TableAdapters.peopleTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_play_finDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.playintheateridDataGridViewTextBoxColumn,
            this.wishgoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.peopleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(240, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // playintheateridDataGridViewTextBoxColumn
            // 
            this.playintheateridDataGridViewTextBoxColumn.DataPropertyName = "play_in_theater_id";
            this.playintheateridDataGridViewTextBoxColumn.HeaderText = "Идет на пьесу в театр с №";
            this.playintheateridDataGridViewTextBoxColumn.Name = "playintheateridDataGridViewTextBoxColumn";
            // 
            // wishgoDataGridViewTextBoxColumn
            // 
            this.wishgoDataGridViewTextBoxColumn.DataPropertyName = "wish_go";
            this.wishgoDataGridViewTextBoxColumn.HeaderText = "Желает пойти на пьесу в театр с №";
            this.wishgoDataGridViewTextBoxColumn.Name = "wishgoDataGridViewTextBoxColumn";
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "people";
            this.peopleBindingSource.DataSource = this.bd_play_finDataSet7;
            // 
            // bd_play_finDataSet7
            // 
            this.bd_play_finDataSet7.DataSetName = "bd_play_finDataSet7";
            this.bd_play_finDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Список людей";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_play_finDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bd_play_finDataSet7 bd_play_finDataSet7;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private bd_play_finDataSet7TableAdapters.peopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playintheateridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wishgoDataGridViewTextBoxColumn;
    }
}