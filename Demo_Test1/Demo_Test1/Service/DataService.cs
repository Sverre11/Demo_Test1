﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Demo_Test1.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Demo_Test1.Service
{
    public static class DataService
    {
        public static Model GetData()
        {                            
                return JsonConvert.DeserializeObject<Model>(Data);            
        }

        public static string Data { get; set; } = "{ 'rooms': [ { 'code': 'L06', 'name': 'Woomkamers', 'thumbnailUrl': 'http://localhost:8200/imgs/rooms/M08S06-small.png', 'imageUrl': 'http://localhost:8200/imgs/rooms/M08S06-large.png', 'categories': [ { 'name': 'Accessories', 'products': [ { 'name': 'Gurli', 'articleNumber': '602.811.44', 'thumbnailUrl': 'http://localhost:8200/imgs/products/GURLI_60281144.JPG', 'inventory': [ { 'epcSku': 'E28011606000020856C95253' } ] }, { 'name': 'Ursula', 'articleNumber': '902.857.20', 'thumbnailUrl': 'http://localhost:8200/imgs/products/URSULA_90285720.JPG', 'inventory': [ { 'epcSku': 'E28011606000020856C95263' } ] }, { 'name': 'Fejka', 'articleNumber': '802.859.59', 'thumbnailUrl': 'http://localhost:8200/imgs/products/FEJKA_10292300.JPG', 'inventory': [ { 'epcSku': 'E28011606000020856C95283', 'epcTag': 'E28011606000020856C95233' } ] }, { 'name': 'Remvallen', 'articleNumber': '603.210.41', 'thumbnailUrl': 'http://localhost:8200/imgs/products/REMVALLEN_60321041.JPG', 'inventory': [ { 'epcSku': 'E28011606000020856C95273' } ] } ] }, { 'name': 'Extra meubiliar' }, { 'name': 'Belangrijkste meubiliar' } ] }, { 'code': 'M01 S16', 'name': 'Eerste vijf', 'thumbnailUrl': 'http://localhost:8200/imgs/rooms/M01S16.png', 'imageUrl': 'http://localhost:8200/imgs/rooms/M01S16.png', } ] }";
    }
}
