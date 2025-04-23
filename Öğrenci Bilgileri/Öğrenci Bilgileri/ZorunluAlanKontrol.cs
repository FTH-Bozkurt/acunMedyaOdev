using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Öğrenci_Bilgileri
{
    public static class ZorunluAlanKontrol
    {
        public static bool IsTrue(object dogrulanacakObje)
        {
            Type dogrulanacakType = dogrulanacakObje.GetType();

            FieldInfo[] dogrulanacakTurAlanlari = dogrulanacakType.GetFields(
                BindingFlags.Public | BindingFlags.Instance);

            foreach (FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOzNitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlan), true);

                if (zorunluAlanOzNitelikleri.Length != 0)
                {
                    object deger = dogrulanacakTurAlani.GetValue(dogrulanacakObje);

                    if (deger == null || (deger is string str && string.IsNullOrWhiteSpace(str)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
