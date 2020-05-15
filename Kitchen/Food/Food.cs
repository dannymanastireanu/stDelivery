﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

/**************************************************************************
 *                                                                        *
 *  File:        FoodMenuActivity.cs                                      *
 *  Copyright:   (c) 2020, Manastireanu Dany                              *
 *  E-mail:      andrei-dany.manastireanu@student.tuiasi.ro               *
 *  Website:     http://127.0.0.1                                         *
 *  Description: Used for deserialization                                 *
 *                                                                        *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

namespace stDelivery.Kitchen
{
    /*
    The enumerable fodd.
    Contains all foods for performing basic food generation.
    */
    /// <summary>
    /// The enumerable fodd.
    /// Contains all foods for performing basic food generation.
    /// </summary>
    public enum TypeOfFood { Pizza=0, Hamburger, Ciorba, Paste, Salata, Desert, Undefined }
    public class Food
    {
        public List<Menuitem> menuitem = new List<Menuitem>();

        public void Add(Menuitem mi)
        {
            this.menuitem.Add(mi);
        }
    }

}