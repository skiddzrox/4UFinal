﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;

namespace _4UFinal
{
    class Prop
    {
        // <declaration>
        private string l_name;
        private string l_desciption;
        private Image l_sprite;
        private int l_warp;
        // </declaration>

        // <initialization> - Name>Description>Source>X>Y>Warp
        public Prop(string name, string description, BitmapImage sprite, Thickness coordinates, int warp = -1)
        {
            l_name = name;
            l_desciption = description;
            l_sprite.Source = sprite;
            l_sprite.Margin = coordinates;
            l_warp = warp;
        }
        // </initialization>

        // <get-sets>
        public string Name
        {
            get => l_name;
            set
            {
                l_name = value;
            }
        }

        public string Description
        {
            get => l_desciption;
            set
            {
                l_desciption = value;
            }
        }

        public Image Sprite
        {
            get => l_sprite;
            set
            {
                l_sprite = value;
            }
        }

        public int Warp
        {
            get => l_warp;
        }
        // </get-sets>
    }
}