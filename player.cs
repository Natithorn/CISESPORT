using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    public class player
    {
        public string name_, Lastname, Id, Mj, displayname, Mail, Number,Team;
        public int Age = 0;


        public player(string name_, string Lastname, string Id, string Mj, string displaygame
        , string Mail, string Number,string Team , int Age)
        {
            this.name_ = name_;
            this.Lastname = Lastname;
            this.Id = Id;
            this.Mj = Mj;
            this.displayname = displaygame;
            this.Mail = Mail;
            this.Number = Number;
            this.Team = Team;  
            this.Age = Age;
        }
    }
}
