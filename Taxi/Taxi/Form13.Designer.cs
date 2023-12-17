namespace Taxi
{
    partial class F13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F13));
            System.Windows.Forms.Label код_автомобиляLabel;
            System.Windows.Forms.Label код_сотрудника_шофёраLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label время_началаLabel;
            System.Windows.Forms.Label время_окончанияLabel;
            this.taxiDataSet = new Taxi.TaxiDataSet();
            this.работаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.работаTableAdapter = new Taxi.TaxiDataSetTableAdapters.РаботаTableAdapter();
            this.tableAdapterManager = new Taxi.TaxiDataSetTableAdapters.TableAdapterManager();
            this.работаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.работаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_автомобиляComboBox = new System.Windows.Forms.ComboBox();
            this.код_сотрудника_шофёраComboBox = new System.Windows.Forms.ComboBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.время_началаTextBox = new System.Windows.Forms.TextBox();
            this.время_окончанияTextBox = new System.Windows.Forms.TextBox();
            this.автомобилиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.автомобилиTableAdapter = new Taxi.TaxiDataSetTableAdapters.АвтомобилиTableAdapter();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new Taxi.TaxiDataSetTableAdapters.ДолжностиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            код_автомобиляLabel = new System.Windows.Forms.Label();
            код_сотрудника_шофёраLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            время_началаLabel = new System.Windows.Forms.Label();
            время_окончанияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingNavigator)).BeginInit();
            this.работаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "TaxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работаBindingSource
            // 
            this.работаBindingSource.DataMember = "Работа";
            this.работаBindingSource.DataSource = this.taxiDataSet;
            // 
            // работаTableAdapter
            // 
            this.работаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Taxi.TaxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = this.автомобилиTableAdapter;
            this.tableAdapterManager.ВызовыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = this.должностиTableAdapter;
            this.tableAdapterManager.Марка_автомобиляTableAdapter = null;
            this.tableAdapterManager.РаботаTableAdapter = this.работаTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТарифыTableAdapter = null;
            // 
            // работаBindingNavigator
            // 
            this.работаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.работаBindingNavigator.BindingSource = this.работаBindingSource;
            this.работаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.работаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.работаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.работаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.работаBindingNavigatorSaveItem});
            this.работаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.работаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.работаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.работаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.работаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.работаBindingNavigator.Name = "работаBindingNavigator";
            this.работаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.работаBindingNavigator.Size = new System.Drawing.Size(375, 27);
            this.работаBindingNavigator.TabIndex = 0;
            this.работаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // работаBindingNavigatorSaveItem
            // 
            this.работаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.работаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("работаBindingNavigatorSaveItem.Image")));
            this.работаBindingNavigatorSaveItem.Name = "работаBindingNavigatorSaveItem";
            this.работаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.работаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.работаBindingNavigatorSaveItem.Click += new System.EventHandler(this.работаBindingNavigatorSaveItem_Click);
            // 
            // код_автомобиляLabel
            // 
            код_автомобиляLabel.AutoSize = true;
            код_автомобиляLabel.Location = new System.Drawing.Point(28, 51);
            код_автомобиляLabel.Name = "код_автомобиляLabel";
            код_автомобиляLabel.Size = new System.Drawing.Size(116, 16);
            код_автомобиляLabel.TabIndex = 1;
            код_автомобиляLabel.Text = "Код автомобиля:";
            // 
            // код_автомобиляComboBox
            // 
            this.код_автомобиляComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работаBindingSource, "Код автомобиля", true));
            this.код_автомобиляComboBox.DataSource = this.автомобилиBindingSource;
            this.код_автомобиляComboBox.DisplayMember = "Код автомобиля";
            this.код_автомобиляComboBox.FormattingEnabled = true;
            this.код_автомобиляComboBox.Location = new System.Drawing.Point(163, 48);
            this.код_автомобиляComboBox.Name = "код_автомобиляComboBox";
            this.код_автомобиляComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_автомобиляComboBox.TabIndex = 2;
            // 
            // код_сотрудника_шофёраLabel
            // 
            код_сотрудника_шофёраLabel.AutoSize = true;
            код_сотрудника_шофёраLabel.Location = new System.Drawing.Point(55, 90);
            код_сотрудника_шофёраLabel.Name = "код_сотрудника_шофёраLabel";
            код_сотрудника_шофёраLabel.Size = new System.Drawing.Size(89, 16);
            код_сотрудника_шофёраLabel.TabIndex = 3;
            код_сотрудника_шофёраLabel.Text = "Код шофёра:";
            // 
            // код_сотрудника_шофёраComboBox
            // 
            this.код_сотрудника_шофёраComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работаBindingSource, "Код сотрудника-шофёра", true));
            this.код_сотрудника_шофёраComboBox.DataSource = this.должностиBindingSource;
            this.код_сотрудника_шофёраComboBox.DisplayMember = "Код должности";
            this.код_сотрудника_шофёраComboBox.FormattingEnabled = true;
            this.код_сотрудника_шофёраComboBox.Location = new System.Drawing.Point(163, 82);
            this.код_сотрудника_шофёраComboBox.Name = "код_сотрудника_шофёраComboBox";
            this.код_сотрудника_шофёраComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_сотрудника_шофёраComboBox.TabIndex = 4;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(102, 120);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(42, 16);
            датаLabel.TabIndex = 5;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.работаBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(163, 114);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 6;
            // 
            // время_началаLabel
            // 
            время_началаLabel.AutoSize = true;
            время_началаLabel.Location = new System.Drawing.Point(42, 150);
            время_началаLabel.Name = "время_началаLabel";
            время_началаLabel.Size = new System.Drawing.Size(102, 16);
            время_началаLabel.TabIndex = 7;
            время_началаLabel.Text = "Время начала:";
            // 
            // время_началаTextBox
            // 
            this.время_началаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работаBindingSource, "Время начала", true));
            this.время_началаTextBox.Location = new System.Drawing.Point(163, 142);
            this.время_началаTextBox.Name = "время_началаTextBox";
            this.время_началаTextBox.Size = new System.Drawing.Size(200, 22);
            this.время_началаTextBox.TabIndex = 8;
            // 
            // время_окончанияLabel
            // 
            время_окончанияLabel.AutoSize = true;
            время_окончанияLabel.Location = new System.Drawing.Point(20, 181);
            время_окончанияLabel.Name = "время_окончанияLabel";
            время_окончанияLabel.Size = new System.Drawing.Size(124, 16);
            время_окончанияLabel.TabIndex = 9;
            время_окончанияLabel.Text = "Время окончания:";
            // 
            // время_окончанияTextBox
            // 
            this.время_окончанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.работаBindingSource, "Время окончания", true));
            this.время_окончанияTextBox.Location = new System.Drawing.Point(163, 175);
            this.время_окончанияTextBox.Name = "время_окончанияTextBox";
            this.время_окончанияTextBox.Size = new System.Drawing.Size(200, 22);
            this.время_окончанияTextBox.TabIndex = 10;
            // 
            // автомобилиBindingSource
            // 
            this.автомобилиBindingSource.DataMember = "Автомобили";
            this.автомобилиBindingSource.DataSource = this.taxiDataSet;
            // 
            // автомобилиTableAdapter
            // 
            this.автомобилиTableAdapter.ClearBeforeFill = true;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.taxiDataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(время_окончанияLabel);
            this.Controls.Add(this.время_окончанияTextBox);
            this.Controls.Add(время_началаLabel);
            this.Controls.Add(this.время_началаTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(код_сотрудника_шофёраLabel);
            this.Controls.Add(this.код_сотрудника_шофёраComboBox);
            this.Controls.Add(код_автомобиляLabel);
            this.Controls.Add(this.код_автомобиляComboBox);
            this.Controls.Add(this.работаBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F13";
            this.Text = "Добавление смен";
            this.Load += new System.EventHandler(this.F13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работаBindingNavigator)).EndInit();
            this.работаBindingNavigator.ResumeLayout(false);
            this.работаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобилиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource работаBindingSource;
        private TaxiDataSetTableAdapters.РаботаTableAdapter работаTableAdapter;
        private TaxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator работаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton работаBindingNavigatorSaveItem;
        private TaxiDataSetTableAdapters.АвтомобилиTableAdapter автомобилиTableAdapter;
        private System.Windows.Forms.ComboBox код_автомобиляComboBox;
        private System.Windows.Forms.ComboBox код_сотрудника_шофёраComboBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox время_началаTextBox;
        private System.Windows.Forms.TextBox время_окончанияTextBox;
        private System.Windows.Forms.BindingSource автомобилиBindingSource;
        private TaxiDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}