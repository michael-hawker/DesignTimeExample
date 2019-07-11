﻿using Windows.UI;

namespace DesignTimeExample.ViewModels
{
    public class ViewModel : IViewModel
    {
        public string Data { get { return "Real data"; } set { } }
        public string Color { get { return "#5EFF00"; } set { } }
    }

    public class ViewModel2
    {
        public string Data { get { return "Real data"; } }
        public string Color { get { return "#FFFF0000"; } }
    }
}
