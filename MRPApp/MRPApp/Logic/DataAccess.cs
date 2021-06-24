using MRPApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRPApp.Logic
{
    public class DataAccess
    {
        // 셋팅테이블에서 데이터 가져오기
        internal static List<Settings> GetSettings()
        {
            List<Model.Settings> settings;

            using (var ctx = new MRPEntities())
            {
                settings = ctx.Settings.ToList();
            }

            return settings;
        }

        internal static int SetSettings(Settings item)
        {
            using (var ctx = new MRPEntities())
            {
                ctx.Settings.AddOrUpdate(item);
                return ctx.SaveChanges();
            }
        }

        internal static int DelSettings(Settings item)
        {
            using (var ctx = new MRPEntities())
            {
                var obj = ctx.Settings.Find(item.BasicCode);
                ctx.Settings.Remove(obj);
                return ctx.SaveChanges();
            }
        }
    }
}