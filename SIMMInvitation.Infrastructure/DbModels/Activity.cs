using System;
using System.Linq;
using System.Text;

namespace SIMMInvitation.Infrastructure.DbModels
{
    ///<summary>
    ///活动表
    ///</summary>
    public partial class Activity
    {
           public Activity(){


           }
           /// <summary>
           /// Desc:活动编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AtyID {get;set;}

           /// <summary>
           /// Desc:所属展会ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Exhid {get;set;}

           /// <summary>
           /// Desc:活动类型编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AtyType {get;set;}

           /// <summary>
           /// Desc:活动主题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyTheme {get;set;}

           /// <summary>
           /// Desc:活动内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyContent {get;set;}

           /// <summary>
           /// Desc:活动日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AtyDate {get;set;}

           /// <summary>
           /// Desc:活动开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyBTime {get;set;}

           /// <summary>
           /// Desc:活动结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyETime {get;set;}

           /// <summary>
           /// Desc:活动地点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyPlace {get;set;}

           /// <summary>
           /// Desc:主讲人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtySpeaker {get;set;}

           /// <summary>
           /// Desc:限定名额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AtyQuota {get;set;}

           /// <summary>
           /// Desc:活动网址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyUrl {get;set;}

           /// <summary>
           /// Desc:活动组织方（0代表主办）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtySource {get;set;}

           /// <summary>
           /// Desc:活动创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AtySourceID {get;set;}

           /// <summary>
           /// Desc:活动创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AtyCreateTime {get;set;}

           /// <summary>
           /// Desc:状态（未审核、已审核、删除）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyStatus {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyObj {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyDateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtyESpeaker {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Atylimit {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? AtyPoint {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtySponsorTitle {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtySponsorETitle {get;set;}

    }
}
