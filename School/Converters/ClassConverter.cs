﻿using School.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace School.Converters
{
    class ClassConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {

            if ((values[0] != null && values[1] != null && values[2] != null && values[3] != null && values[4] != null) &&
                (!values[0].Equals("") && !values[1].Equals("") && !values[2].Equals("") && !values[3].Equals("") && !values[4].Equals("")))
            {
                return new ClassVM()
                {
                    IdClass = int.Parse(values[0].ToString()),
                    Name = values[1].ToString(),
                    Year = int.Parse(values[2].ToString()),
                    Field = values[3].ToString(),
                    FkClassmaster = int.Parse(values[4].ToString())
                };
            }
            else
            {
                return null;
            }
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            ClassVM @class = value as ClassVM;

            object[] result = new object[5]
            {
                @class.IdClass,
                @class.Name,
                @class.Year,
                @class.Field,
                @class.FkClassmaster
            };

            return result;
        }
    }
}
