﻿/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/

namespace NFine.Code
{
    public class TreeSelectModel
    {
        public string id { get; set; }
        public string text { get; set; }
        public string parentId { get; set; }
        public string OrderName { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public object data { get; set; }
    }
}
