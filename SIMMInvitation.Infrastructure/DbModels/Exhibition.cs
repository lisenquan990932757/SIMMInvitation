using System;
using System.Linq;
using System.Text;

namespace SIMMInvitation.Infrastructure.DbModels
{
    ///<summary>
    ///
    ///</summary>
    public partial class Exhibition
    {
           public Exhibition(){


           }
           /// <summary>
           /// Desc:展会ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ExhID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ExhManagerID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool ExhIfCompany {get;set;}

           /// <summary>
           /// Desc:
           /// Default:呼叫中心
           /// Nullable:False
           /// </summary>           
           public string ExhGroup {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? QtrID {get;set;}

           /// <summary>
           /// Desc:展会名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string exhName {get;set;}

           /// <summary>
           /// Desc:是否确定
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool exhifconfirm {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime exhbtime {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? exhetime {get;set;}

           /// <summary>
           /// Desc:城市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhcity {get;set;}

           /// <summary>
           /// Desc:场馆ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? exhehcid {get;set;}

           /// <summary>
           /// Desc:详细介绍
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhdetail {get;set;}

           /// <summary>
           /// Desc:展品范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhscope {get;set;}

           /// <summary>
           /// Desc:所属行业
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhtrade {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhtrade1 {get;set;}

           /// <summary>
           /// Desc:预计展会面积
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? exhAcreage {get;set;}

           /// <summary>
           /// Desc:联系进展
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string charProcess {get;set;}

           /// <summary>
           /// Desc:展会网址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhweburl {get;set;}

           /// <summary>
           /// Desc:观众数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? intCustNumber {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? exhRecommend {get;set;}

           /// <summary>
           /// Desc:优先级
           /// Default:2
           /// Nullable:True
           /// </summary>           
           public int? exhpriority {get;set;}

           /// <summary>
           /// Desc:联系信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhlinkinfo {get;set;}

           /// <summary>
           /// Desc:组织信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhorginfo {get;set;}

           /// <summary>
           /// Desc:销售情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhextInfo {get;set;}

           /// <summary>
           /// Desc:初始信息添加人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhcreator {get;set;}

           /// <summary>
           /// Desc:'短的展会名称'
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhsName {get;set;}

           /// <summary>
           /// Desc:英文名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exheName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? exhcreatetime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? exhHandletime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool exhIfAudited {get;set;}

           /// <summary>
           /// Desc:点击数
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int exhClickNum {get;set;}

           /// <summary>
           /// Desc:最近一月访问次数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? exhNumlastmonth {get;set;}

           /// <summary>
           /// Desc:最近一周访问次数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? exhNumlastweek {get;set;}

           /// <summary>
           /// Desc:此展会在未开展会中的排名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? exhOrder {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int exhZhichiNum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? exhFanduiNum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? exhlastexhid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? exhStallNum {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:True
           /// </summary>           
           public int? exhAttend {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string exhsubplace {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhProject {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhMaxCurrentCard {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhParentID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhShowRooms {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public short? exhifVisit {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhRemark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ModifierID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhOwner {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ExhInviteActorOjaID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ExhServiceOjaID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhESName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ExhSynExhID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ExhActorManagerID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ExhDetailEn {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ExhMarOfficerID {get;set;}

    }
}
