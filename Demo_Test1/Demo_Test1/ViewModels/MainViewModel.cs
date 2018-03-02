using System;
using System.Collections.Generic;
using System.Text;
using Demo_Test1.Models;
using Demo_Test1.Service;

namespace Demo_Test1.ViewModels
{
    public class MainViewModel
    {
        public string Hello  { get; set; }
        public Model Data { get; set; }

        public MainViewModel()
        {
            Hello = "Hello Leo";
            Data = DataService.GetData();
        }




    }
}
