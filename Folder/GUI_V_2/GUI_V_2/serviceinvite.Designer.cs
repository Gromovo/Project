namespace GUI_V_2.Core.View
{
    partial class serviceinvite
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label _Label;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label мобильный_телефонLabel;
            System.Windows.Forms.Label заработная_платаLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label дата_приема_на_работуLabel;
            System.Windows.Forms.Label дополнительная_информацияLabel;
            this.serviceDataSet = new GUI_V_2.Core.View.ServiceDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new GUI_V_2.Core.View.ServiceDataSetTableAdapters.serviceTableAdapter();
            this.tableAdapterManager = new GUI_V_2.Core.View.ServiceDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this._TextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.мобильный_телефонTextBox = new System.Windows.Forms.TextBox();
            this.заработная_платаTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.дата_приема_на_работуDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дополнительная_информацияTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            _Label = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            мобильный_телефонLabel = new System.Windows.Forms.Label();
            заработная_платаLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            дата_приема_на_работуLabel = new System.Windows.Forms.Label();
            дополнительная_информацияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            idLabel.Location = new System.Drawing.Point(99, 95);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 18);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // _Label
            // 
            _Label.AutoSize = true;
            _Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            _Label.Location = new System.Drawing.Point(99, 125);
            _Label.Name = "_Label";
            _Label.Size = new System.Drawing.Size(27, 18);
            _Label.TabIndex = 3;
            _Label.Text = "№:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            имяLabel.Location = new System.Drawing.Point(413, 151);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(42, 18);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            фамилияLabel.Location = new System.Drawing.Point(386, 191);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(77, 18);
            фамилияLabel.TabIndex = 7;
            фамилияLabel.Text = "Фамилия:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            отчествоLabel.Location = new System.Drawing.Point(385, 231);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(79, 18);
            отчествоLabel.TabIndex = 9;
            отчествоLabel.Text = "Отчество:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            дата_рожденияLabel.Location = new System.Drawing.Point(345, 269);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(120, 18);
            дата_рожденияLabel.TabIndex = 11;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            адресLabel.Location = new System.Drawing.Point(409, 308);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(54, 18);
            адресLabel.TabIndex = 13;
            адресLabel.Text = "Адрес:";
            // 
            // мобильный_телефонLabel
            // 
            мобильный_телефонLabel.AutoSize = true;
            мобильный_телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            мобильный_телефонLabel.Location = new System.Drawing.Point(305, 346);
            мобильный_телефонLabel.Name = "мобильный_телефонLabel";
            мобильный_телефонLabel.Size = new System.Drawing.Size(161, 18);
            мобильный_телефонLabel.TabIndex = 15;
            мобильный_телефонLabel.Text = "Мобильный телефон:";
            // 
            // заработная_платаLabel
            // 
            заработная_платаLabel.AutoSize = true;
            заработная_платаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            заработная_платаLabel.Location = new System.Drawing.Point(327, 384);
            заработная_платаLabel.Name = "заработная_платаLabel";
            заработная_платаLabel.Size = new System.Drawing.Size(139, 18);
            заработная_платаLabel.TabIndex = 17;
            заработная_платаLabel.Text = "Заработная плата:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            должностьLabel.Location = new System.Drawing.Point(372, 416);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(93, 18);
            должностьLabel.TabIndex = 19;
            должностьLabel.Text = "Должность:";
            // 
            // дата_приема_на_работуLabel
            // 
            дата_приема_на_работуLabel.AutoSize = true;
            дата_приема_на_работуLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            дата_приема_на_работуLabel.Location = new System.Drawing.Point(294, 451);
            дата_приема_на_работуLabel.Name = "дата_приема_на_работуLabel";
            дата_приема_на_работуLabel.Size = new System.Drawing.Size(174, 18);
            дата_приема_на_работуLabel.TabIndex = 21;
            дата_приема_на_работуLabel.Text = "Дата приема на работу:";
            // 
            // дополнительная_информацияLabel
            // 
            дополнительная_информацияLabel.AutoSize = true;
            дополнительная_информацияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            дополнительная_информацияLabel.Location = new System.Drawing.Point(247, 490);
            дополнительная_информацияLabel.Name = "дополнительная_информацияLabel";
            дополнительная_информацияLabel.Size = new System.Drawing.Size(224, 18);
            дополнительная_информацияLabel.TabIndex = 23;
            дополнительная_информацияLabel.Text = "Дополнительная информация:";
            // 
            // serviceDataSet
            // 
            this.serviceDataSet.DataSetName = "ServiceDataSet";
            this.serviceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "service";
            this.serviceBindingSource.DataSource = this.serviceDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.serviceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager.UpdateOrder = GUI_V_2.Core.View.ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.idTextBox.Location = new System.Drawing.Point(42, 89);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(31, 24);
            this.idTextBox.TabIndex = 2;
            // 
            // _TextBox
            // 
            this._TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "№", true));
            this._TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this._TextBox.Location = new System.Drawing.Point(42, 119);
            this._TextBox.Name = "_TextBox";
            this._TextBox.Size = new System.Drawing.Size(31, 24);
            this._TextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Имя", true));
            this.имяTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.имяTextBox.Location = new System.Drawing.Point(42, 151);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 24);
            this.имяTextBox.TabIndex = 6;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Фамилия", true));
            this.фамилияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.фамилияTextBox.Location = new System.Drawing.Point(42, 191);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 24);
            this.фамилияTextBox.TabIndex = 8;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Отчество", true));
            this.отчествоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.отчествоTextBox.Location = new System.Drawing.Point(42, 231);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 24);
            this.отчествоTextBox.TabIndex = 10;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.serviceBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(42, 269);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.дата_рожденияDateTimePicker.TabIndex = 12;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.адресTextBox.Location = new System.Drawing.Point(42, 309);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(200, 24);
            this.адресTextBox.TabIndex = 14;
            // 
            // мобильный_телефонTextBox
            // 
            this.мобильный_телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Мобильный телефон", true));
            this.мобильный_телефонTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.мобильный_телефонTextBox.Location = new System.Drawing.Point(42, 347);
            this.мобильный_телефонTextBox.Name = "мобильный_телефонTextBox";
            this.мобильный_телефонTextBox.Size = new System.Drawing.Size(200, 24);
            this.мобильный_телефонTextBox.TabIndex = 16;
            // 
            // заработная_платаTextBox
            // 
            this.заработная_платаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Заработная плата", true));
            this.заработная_платаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.заработная_платаTextBox.Location = new System.Drawing.Point(42, 383);
            this.заработная_платаTextBox.Name = "заработная_платаTextBox";
            this.заработная_платаTextBox.Size = new System.Drawing.Size(200, 24);
            this.заработная_платаTextBox.TabIndex = 18;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Должность", true));
            this.должностьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.должностьTextBox.Location = new System.Drawing.Point(42, 416);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(200, 24);
            this.должностьTextBox.TabIndex = 20;
            // 
            // дата_приема_на_работуDateTimePicker
            // 
            this.дата_приема_на_работуDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.serviceBindingSource, "Дата приема на работу", true));
            this.дата_приема_на_работуDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.дата_приема_на_работуDateTimePicker.Location = new System.Drawing.Point(42, 452);
            this.дата_приема_на_работуDateTimePicker.Name = "дата_приема_на_работуDateTimePicker";
            this.дата_приема_на_работуDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.дата_приема_на_работуDateTimePicker.TabIndex = 22;
            // 
            // дополнительная_информацияTextBox
            // 
            this.дополнительная_информацияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "Дополнительная информация", true));
            this.дополнительная_информацияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.дополнительная_информацияTextBox.Location = new System.Drawing.Point(42, 490);
            this.дополнительная_информацияTextBox.Name = "дополнительная_информацияTextBox";
            this.дополнительная_информацияTextBox.Size = new System.Drawing.Size(200, 24);
            this.дополнительная_информацияTextBox.TabIndex = 24;
            // 
            // serviceinvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 581);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(_Label);
            this.Controls.Add(this._TextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(мобильный_телефонLabel);
            this.Controls.Add(this.мобильный_телефонTextBox);
            this.Controls.Add(заработная_платаLabel);
            this.Controls.Add(this.заработная_платаTextBox);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьTextBox);
            this.Controls.Add(дата_приема_на_работуLabel);
            this.Controls.Add(this.дата_приема_на_работуDateTimePicker);
            this.Controls.Add(дополнительная_информацияLabel);
            this.Controls.Add(this.дополнительная_информацияTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "serviceinvite";
            this.Text = "serviceinvite";
            this.Load += new System.EventHandler(this.serviceinvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ServiceDataSet serviceDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private ServiceDataSetTableAdapters.serviceTableAdapter serviceTableAdapter;
        private ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox _TextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox мобильный_телефонTextBox;
        private System.Windows.Forms.TextBox заработная_платаTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.DateTimePicker дата_приема_на_работуDateTimePicker;
        private System.Windows.Forms.TextBox дополнительная_информацияTextBox;
    }
}