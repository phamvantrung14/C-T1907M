using System;
using System.Collections.Generic;

namespace QlStudents.Ass3_Java
{
    public class PersonModel
    {
        public void Add(List<Object> list,Strudent ob)
        {
            list.Add(ob);
        }

        public void ShowInfo(List<Strudent> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].ToString();
            }
        }
    }
}