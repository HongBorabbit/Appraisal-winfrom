using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment.Common
{
     public  class FormFactory
    {
        //private static FrmUserManager frmUserManager;
        //private static FrmBaseManager frmBaseManager;
        private static Form form;
        private static List<Form> forms = new List<Form>();
        //public static Form CreateFrom(int index)
        //{
        //    HideFormAll();
        //    // 判断点击弹出窗体
        //    switch (index)
        //    {
        //        case 0:
        //            if (frmUserManager == null)
        //            {
        //                frmUserManager = new FrmUserManager();
        //                forms.Add(frmUserManager);
        //            }
        //            form = frmUserManager;
        //            break;
        //        case 1:
        //            if (frmBaseManager == null)
        //            {
        //                frmBaseManager = new FrmBaseManager();
        //                forms.Add(frmBaseManager);
        //            }
        //            form = frmBaseManager;
        //            break;
        //        default:
        //            break;
        //    }
        //    return form;
        //}

        private static List<Type> types;
        /// <summary>
        /// 静态构造方法
        /// </summary>
        static FormFactory()
        {
            Assembly ass = Assembly.LoadFrom("Assessment.exe");
            types = ass.GetTypes().ToList();
        }
        public static Form CreateFrom(string formName)
        {
            HideFormAll();
            Form form = forms.Find(m => m.Name == formName);
            if (form ==null)
            {
                Type type = types.Find(m => m.Name == formName);
                form = (Form)Activator.CreateInstance(type);
                forms.Add(form);
            }
            return form;
        }
        public static void HideFormAll()
        {
            // forms 存放已经实例化的窗体
            foreach (var form in forms)
            {
                form.Hide();
            }

        }
    }
}
