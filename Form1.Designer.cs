namespace app
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbStrData = new System.Windows.Forms.GroupBox();
            this.rbLinkedList = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbArray = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.lSize = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.nudPercent = new System.Windows.Forms.NumericUpDown();
            this.lPercent = new System.Windows.Forms.Label();
            this.rbPartOrd = new System.Windows.Forms.RadioButton();
            this.rbBackOrd = new System.Windows.Forms.RadioButton();
            this.rbOrd = new System.Windows.Forms.RadioButton();
            this.rbDisord = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chartGrpah = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.Alghoritm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twenty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fourty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fifty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seventy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eighty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ninety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hundred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStrData.SuspendLayout();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.gbType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrpah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStrData
            // 
            this.gbStrData.Controls.Add(this.rbLinkedList);
            this.gbStrData.Controls.Add(this.rbList);
            this.gbStrData.Controls.Add(this.rbArray);
            this.gbStrData.Location = new System.Drawing.Point(13, 10);
            this.gbStrData.Name = "gbStrData";
            this.gbStrData.Size = new System.Drawing.Size(200, 127);
            this.gbStrData.TabIndex = 0;
            this.gbStrData.TabStop = false;
            this.gbStrData.Text = "Структура данных";
            // 
            // rbLinkedList
            // 
            this.rbLinkedList.AutoSize = true;
            this.rbLinkedList.Location = new System.Drawing.Point(7, 77);
            this.rbLinkedList.Name = "rbLinkedList";
            this.rbLinkedList.Size = new System.Drawing.Size(128, 17);
            this.rbLinkedList.TabIndex = 2;
            this.rbLinkedList.Text = "Двусвязный список";
            this.rbLinkedList.UseVisualStyleBackColor = true;
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(7, 53);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(134, 17);
            this.rbList.TabIndex = 1;
            this.rbList.Text = "Односвязный список";
            this.rbList.UseVisualStyleBackColor = true;
            // 
            // rbArray
            // 
            this.rbArray.AutoSize = true;
            this.rbArray.Location = new System.Drawing.Point(7, 29);
            this.rbArray.Name = "rbArray";
            this.rbArray.Size = new System.Drawing.Size(64, 17);
            this.rbArray.TabIndex = 0;
            this.rbArray.Text = "Массив";
            this.rbArray.UseVisualStyleBackColor = true;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.lSize);
            this.gbSize.Controls.Add(this.nudSize);
            this.gbSize.Location = new System.Drawing.Point(13, 145);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 100);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Ввод размера";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(10, 31);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(184, 13);
            this.lSize.TabIndex = 1;
            this.lSize.Text = "Размерность последовательности";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(16, 61);
            this.nudSize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(166, 20);
            this.nudSize.TabIndex = 0;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.nudPercent);
            this.gbType.Controls.Add(this.lPercent);
            this.gbType.Controls.Add(this.rbPartOrd);
            this.gbType.Controls.Add(this.rbBackOrd);
            this.gbType.Controls.Add(this.rbOrd);
            this.gbType.Controls.Add(this.rbDisord);
            this.gbType.Location = new System.Drawing.Point(13, 260);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(200, 179);
            this.gbType.TabIndex = 2;
            this.gbType.TabStop = false;
            this.gbType.Text = "Тип последовательности";
            // 
            // nudPercent
            // 
            this.nudPercent.Enabled = false;
            this.nudPercent.Location = new System.Drawing.Point(16, 143);
            this.nudPercent.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudPercent.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(166, 20);
            this.nudPercent.TabIndex = 5;
            // 
            // lPercent
            // 
            this.lPercent.AutoSize = true;
            this.lPercent.Location = new System.Drawing.Point(29, 124);
            this.lPercent.Name = "lPercent";
            this.lPercent.Size = new System.Drawing.Size(140, 13);
            this.lPercent.TabIndex = 4;
            this.lPercent.Text = "Процент упорядоченности";
            // 
            // rbPartOrd
            // 
            this.rbPartOrd.AutoSize = true;
            this.rbPartOrd.Location = new System.Drawing.Point(7, 102);
            this.rbPartOrd.Name = "rbPartOrd";
            this.rbPartOrd.Size = new System.Drawing.Size(152, 17);
            this.rbPartOrd.TabIndex = 3;
            this.rbPartOrd.TabStop = true;
            this.rbPartOrd.Text = "Частично упорядоченная";
            this.rbPartOrd.UseVisualStyleBackColor = true;
            this.rbPartOrd.CheckedChanged += new System.EventHandler(this.rbPartOrd_CheckedChanged);
            // 
            // rbBackOrd
            // 
            this.rbBackOrd.AutoSize = true;
            this.rbBackOrd.Location = new System.Drawing.Point(7, 65);
            this.rbBackOrd.Name = "rbBackOrd";
            this.rbBackOrd.Size = new System.Drawing.Size(128, 30);
            this.rbBackOrd.TabIndex = 2;
            this.rbBackOrd.TabStop = true;
            this.rbBackOrd.Text = "Упорядоченная\nв обратном порядке";
            this.rbBackOrd.UseVisualStyleBackColor = true;
            // 
            // rbOrd
            // 
            this.rbOrd.AutoSize = true;
            this.rbOrd.Location = new System.Drawing.Point(7, 44);
            this.rbOrd.Name = "rbOrd";
            this.rbOrd.Size = new System.Drawing.Size(104, 17);
            this.rbOrd.TabIndex = 1;
            this.rbOrd.TabStop = true;
            this.rbOrd.Text = "Упорядоченная";
            this.rbOrd.UseVisualStyleBackColor = true;
            // 
            // rbDisord
            // 
            this.rbDisord.AutoSize = true;
            this.rbDisord.Location = new System.Drawing.Point(7, 20);
            this.rbDisord.Name = "rbDisord";
            this.rbDisord.Size = new System.Drawing.Size(115, 17);
            this.rbDisord.TabIndex = 0;
            this.rbDisord.TabStop = true;
            this.rbDisord.Text = "Неупорядоченная";
            this.rbDisord.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(13, 449);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(200, 41);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(13, 500);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Выйти";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chartGrpah
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrpah.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Алгоритмы сортировки";
            this.chartGrpah.Legends.Add(legend1);
            this.chartGrpah.Location = new System.Drawing.Point(219, 10);
            this.chartGrpah.Name = "chartGrpah";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Метод прямого обмена";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series2.Legend = "Legend1";
            series2.Name = "Шейкерная сортировка";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Метод прямого обмена\\nс запоминанем позиции\\nпоследней перестановки";
            series3.YValuesPerPoint = 2;
            this.chartGrpah.Series.Add(series1);
            this.chartGrpah.Series.Add(series2);
            this.chartGrpah.Series.Add(series3);
            this.chartGrpah.Size = new System.Drawing.Size(901, 329);
            this.chartGrpah.TabIndex = 5;
            this.chartGrpah.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Графическое сравнение алгоритмов сортировки";
            this.chartGrpah.Titles.Add(title1);
            // 
            // resultTable
            // 
            this.resultTable.AllowUserToAddRows = false;
            this.resultTable.AllowUserToDeleteRows = false;
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alghoritm,
            this.ten,
            this.twenty,
            this.thirty,
            this.fourty,
            this.fifty,
            this.sixty,
            this.seventy,
            this.eighty,
            this.ninety,
            this.hundred});
            this.resultTable.Location = new System.Drawing.Point(236, 362);
            this.resultTable.Name = "resultTable";
            this.resultTable.Size = new System.Drawing.Size(884, 179);
            this.resultTable.TabIndex = 6;
            this.resultTable.Rows.Add("Метод прямого обмена");
            this.resultTable.Rows.Add("Шейкерная сортировка");
            this.resultTable.Rows.Add("Метод прямого обмена с запоминанием позиции последней перестановки");
            // 
            // Alghoritm
            // 
            this.Alghoritm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Alghoritm.HeaderText = "Алгоритм сортировки";
            this.Alghoritm.Name = "Alghoritm";
            this.Alghoritm.ReadOnly = true;
            this.Alghoritm.Width = 391;
            // 
            // ten
            // 
            this.ten.HeaderText = "10%";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // twenty
            // 
            this.twenty.HeaderText = "20%";
            this.twenty.Name = "twenty";
            this.twenty.ReadOnly = true;
            // 
            // thirty
            // 
            this.thirty.HeaderText = "30%";
            this.thirty.Name = "thirty";
            this.thirty.ReadOnly = true;
            // 
            // fourty
            // 
            this.fourty.HeaderText = "40%";
            this.fourty.Name = "fourty";
            this.fourty.ReadOnly = true;
            // 
            // fifty
            // 
            this.fifty.HeaderText = "50%";
            this.fifty.Name = "fifty";
            this.fifty.ReadOnly = true;
            // 
            // sixty
            // 
            this.sixty.HeaderText = "60%";
            this.sixty.Name = "sixty";
            this.sixty.ReadOnly = true;
            // 
            // seventy
            // 
            this.seventy.HeaderText = "70%";
            this.seventy.Name = "seventy";
            this.seventy.ReadOnly = true;
            // 
            // eighty
            // 
            this.eighty.HeaderText = "80%";
            this.eighty.Name = "eighty";
            this.eighty.ReadOnly = true;
            // 
            // ninety
            // 
            this.ninety.HeaderText = "90%";
            this.ninety.Name = "ninety";
            this.ninety.ReadOnly = true;
            // 
            // hundred
            // 
            this.hundred.HeaderText = "100%";
            this.hundred.Name = "hundred";
            this.hundred.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 554);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.chartGrpah);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbStrData);
            this.Name = "MainForm";
            this.Text = "Костиневич 23ВП2";
            this.gbStrData.ResumeLayout(false);
            this.gbStrData.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrpah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStrData;
        private System.Windows.Forms.RadioButton rbLinkedList;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbArray;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbBackOrd;
        private System.Windows.Forms.RadioButton rbOrd;
        private System.Windows.Forms.RadioButton rbDisord;
        private System.Windows.Forms.RadioButton rbPartOrd;
        private System.Windows.Forms.NumericUpDown nudPercent;
        private System.Windows.Forms.Label lPercent;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrpah;
        private System.Windows.Forms.DataGridView resultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alghoritm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn twenty;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirty;
        private System.Windows.Forms.DataGridViewTextBoxColumn fourty;
        private System.Windows.Forms.DataGridViewTextBoxColumn fifty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixty;
        private System.Windows.Forms.DataGridViewTextBoxColumn seventy;
        private System.Windows.Forms.DataGridViewTextBoxColumn eighty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninety;
        private System.Windows.Forms.DataGridViewTextBoxColumn hundred;
    }
}

