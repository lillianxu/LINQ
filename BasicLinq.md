# 3 ways for query LINQLambda
solution-Add code to source control-team explorer-syn


//1.basic query

            //1
            var ss = from r in db.Am_recProScheme
                     select r;
            //2
            var ss1 = db.Am_recProScheme;
            //3
            string sssql = "select * from Am_recProScheme";
 //2 where query
            //1
            var ss = from r in db.Am_recProScheme
                     where r.rpId > 10
                     select r;
            //2
            var ss1 = db.Am_recProScheme.Where(p => p.rpId > 10);
            //3
            string sssql = "select * from Am_recProScheme where rpid>10";


//3.（count，min，max，sum）
            //1
            ////get max rpId
            //var ss = (from r in db.Am_recProScheme
            //          select r).Max(p => p.rpId);
            ////get min rpId
            //var ss = (from r in db.Am_recProScheme
            //          select r).Min(p => p.rpId);
            //get count
            //var ss = (from r in db.Am_recProScheme                  
            //         select r).Count();
            //get sum(rpId)
            var ss = (from r in db.Am_recProScheme
                      select r).Sum(p => p.rpId);


            //2
            //var ss1 = db.Am_recProScheme.Max(p=>p.rpId);
            //var ss1 = db.Am_recProScheme.Min(p => p.rpId);
            //var ss1 = db.Am_recProScheme.Count() ;
            var ss1 = db.Am_recProScheme.Sum(p => p.rpId);
            Response.Write(ss);

            //3
            string sssql = "select max(rpId) from Am_recProScheme";
                   sssql = "select min(rpId) from Am_recProScheme";
                   sssql = "select count(1) from Am_recProScheme";
                   sssql = "select sum(rpId) from Am_recProScheme";

4.order by desc/asc
             //1
            var ss = from r in db.Am_recProScheme
           where r.rpId > 10
           orderby r.rpId descending  
           //  orderby r.rpId ascending   
           select r;

            //2
            var ss1 = db.Am_recProScheme.OrderBy(p => p.rpId).Where(p => p.rpId > 10).ToList();
            var ss2 = db.Am_recProScheme.OrderByDescending(p => p.rpId).Where(p => p.rpId > 10).ToList();

            string sssql = "select * from Am_recProScheme where rpid>10 order by rpId [desc|asc]";

5.top(1)
//if get the last record, can decending order at first, then get record
            var ss = (from r in db.Am_recProScheme                     
                      select r).FirstOrDefault();

            //（）linq to ef does not support Last() 
            var ss1 = db.Am_recProScheme.FirstOrDefault();
            //var ss1 = db.Am_recProScheme.First();          

            string sssql = "select top(1) * from Am_recProScheme";

6.skip 10 records get records
            //1
            var ss = (from r in db.Am_recProScheme
                      orderby r.rpId descending
                      select r).Skip(10); //skip 10 records get other records
            //2  
            var ss1 = db.Am_recProScheme.OrderByDescending(p => p.rpId).Skip(10).ToList();
            //3
            string sssql = "select * from  (select ROW_NUMBER()over(order by rpId desc) as rowNum, * from [Am_recProScheme]) as t where rowNum>10";

7get recored from11-20
           //1
            var ss = (from r in db.Am_recProScheme
                      where r.rpId > 10
                      orderby r.rpId descending
                      select r).Skip(10).Take(10);                   

            //2 Take(10): 
            var ss1 = db.Am_recProScheme.OrderByDescending(p => p.rpId).Where(p => p.rpId > 10).Skip(10).Take(10).ToList();
            //3
            string sssql = "select * from  (select ROW_NUMBER()over(order by rpId desc) as rowNum, * from [Am_recProScheme]) as t where rowNum>10 and rowNum<=20";

8.contain  like '%%'

            //1
            var ss = from r in db.Am_recProScheme
                     where r.SortsText.Contains("Lillian")
                     select r;
            //2
            var ss1 = db.Am_recProScheme.Where(p => p.SortsText.Contains("Lillian ")).ToList();
            //3
            string sssql = "select * from Am_recProScheme where SortsText like '% Lillian %'";

9. group by

            //1
            var ss = from r in db.Am_recProScheme
                     orderby r.rpId descending
                     group r by r.recType into n
                     select new
                     {
                         n.Key,  //Key is recType
                         rpId = n.Sum(r => r.rpId), //max rpId in group
                         MaxRpId = n.Max(r => r.rpId),//max rpId in group
                         MinRpId = n.Min(r => r.rpId), //min rpId in group
                     };
            foreach (var t in ss)
            {
                Response.Write(t.Key + "--" + t.rpId + "--" + t.MaxRpId + "--" + t.MinRpId);
            }
            //2
            var ss1 = from r in db.Am_recProScheme
                     orderby r.rpId descending
                     group r by r.recType into n
                     select n;
            foreach (var t in ss1)
            {
                Response.Write(t.Key + "--" + t.Min(p => p.rpId));
            }
            //3
            var ss2 = db.Am_recProScheme.GroupBy(p => p.recType);
            foreach (var t in ss2)
            {
                Response.Write(t.Key + "--" + t.Min(p => p.rpId));
            }
            //4
            string sssql = "select recType,min(rpId),max(rpId),sum(rpId) from Am_recProScheme group by recType";

10.Join 

            //1
            var ss = from r in db.Am_recProScheme
                     join w in db.Am_Test_Result on r.rpId equals w.rsId
                     orderby r.rpId descending
                     select r;
            //2
            var ss1 = db.Am_recProScheme.Join(db.Am_Test_Result, p => p.rpId, r => r.rsId, (p, r) => p).OrderByDescending(p => p.rpId).ToList();
            //3
            string sssql = "select r.* from  [Am_recProScheme] as r inner join [dbo].[Am_Test_Result] as t on r.[rpId] = t.[rsId] order by r.[rpId] desc";

11.sql- In

            //1
            var ss = from p in db.Am_recProScheme
                              where (new int?[] { 24, 25,26 }).Contains(p.rpId)
                              select p;
            foreach (var p in ss)
            {
                Response.Write(p.Sorts);
            }
            //2
            string st = "select * from Am_recProScheme where rpId in(24,25,26)";



