using System;
using System.Linq;
using System.Text;

namespace SIMMInvitation.Infrastructure.DbModels
{
    ///<summary>
    ///
    ///</summary>
    public partial class Setting
    {
           public Setting(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SetID {get;set;}

           /// <summary>
           /// Desc:展会id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ExhID {get;set;}

           /// <summary>
           /// Desc:设定人id
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? PsnID {get;set;}

           /// <summary>
           /// Desc:键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SetKey {get;set;}

           /// <summary>
           /// Desc:值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SetValue {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SetType {get;set;}

           /// <summary>
           /// Desc:公司id
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? ComID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SetSort {get;set;}

    }
}
