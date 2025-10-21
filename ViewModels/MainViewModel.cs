using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace datacollection.ViewModels
{
    /// <summary>
    /// 主窗口视图模型
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<DataItem> _dataItems;
        private DateTime _currentDateTime;
        private DataItem _selectedItem;

        /// <summary>
        /// 数据列表集合
        /// </summary>
        public ObservableCollection<DataItem> DataItems
        {
            get => _dataItems;
            set
            {
                _dataItems = value;
                OnPropertyChanged(nameof(DataItems));
            }
        }

        /// <summary>
        /// 当前日期时间（用于显示在特定位置）
        /// </summary>
        public DateTime CurrentDateTime
        {
            get => _currentDateTime;
            set
            {
                _currentDateTime = value;
                OnPropertyChanged(nameof(CurrentDateTime));
            }
        }

        /// <summary>
        /// 构造函数，初始化数据
        /// </summary>
        public MainViewModel()
        {
            // 初始化数据列表
            DataItems = new ObservableCollection<DataItem>
            {
                // 第一行第一列的数据项
                new DataItem { Name = "温度", Value = "25.6°C", DateTime = DateTime.Now },
                // 第二行第一列的数据项
                new DataItem { Name = "湿度", Value = "60%", DateTime = DateTime.Now.AddMinutes(-5) },
                // 第三行第一列的数据项
                new DataItem { Name = "压力", Value = "101.3kPa", DateTime = DateTime.Now.AddMinutes(-10) }
            };

            // 设置当前时间
            CurrentDateTime = DateTime.Now;
        }

        /// <summary>
        /// 当前选中的数据项
        /// </summary>
        public DataItem SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        // 实现INotifyPropertyChanged接口
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// 数据项模型
    /// </summary>
    public class DataItem : INotifyPropertyChanged
    {
        private string _name;
        private string _value;
        private DateTime _dateTime;

        /// <summary>
        /// 数据名称
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// 数据值
        /// </summary>
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        /// <summary>
        /// 数据时间戳
        /// </summary>
        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
                OnPropertyChanged(nameof(DateTime));
            }
        }

        // 实现INotifyPropertyChanged接口，用于通知UI数据变化
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}