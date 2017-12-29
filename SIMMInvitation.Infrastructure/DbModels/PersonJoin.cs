using System;
using System.Linq;
using System.Text;

namespace SIMMInvitation.Infrastructure.DbModels
{
    ///<summary>
    ///
    ///</summary>
    public partial class PersonJoin
    {
           public PersonJoin(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PsjID {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjName {get;set;}

           /// <summary>
           /// Desc:FIRSTNAME
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjFirstEName {get;set;}

           /// <summary>
           /// Desc:LASTNAME
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjLastEName {get;set;}

           /// <summary>
           /// Desc:称呼
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjGender {get;set;}

           /// <summary>
           /// Desc:公司名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComName {get;set;}

           /// <summary>
           /// Desc:第二单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComEName {get;set;}

           /// <summary>
           /// Desc:所属行业
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjTrade {get;set;}

           /// <summary>
           /// Desc:观众级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjLevel {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjJoinType {get;set;}

           /// <summary>
           /// Desc:观众类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjCountryCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjCityCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjContinent {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjCountry {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjArea {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjProvince {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjCity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjDistrict {get;set;}

           /// <summary>
           /// Desc:网址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjWebUrl {get;set;}

           /// <summary>
           /// Desc:EMAIL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjEmail {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjEmail1 {get;set;}

           /// <summary>
           /// Desc:联系地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjAddress {get;set;}

           /// <summary>
           /// Desc:第二地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjEAddress {get;set;}

           /// <summary>
           /// Desc:手机
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjMobile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjMobile1 {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjTel {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjTel1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjTel2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjQQ {get;set;}

           /// <summary>
           /// Desc:传真
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjFax {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjFax1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjFax2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjOtherLinkInfo {get;set;}

           /// <summary>
           /// Desc:邮编
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjZipCode {get;set;}

           /// <summary>
           /// Desc:职务
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjRank {get;set;}

           /// <summary>
           /// Desc:POSITION
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjERank {get;set;}

           /// <summary>
           /// Desc:部门
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjDept {get;set;}

           /// <summary>
           /// Desc:DEPATRMENT
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjEDept {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjUnifyRank {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjUnifyDept {get;set;}

           /// <summary>
           /// Desc:身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjIDCard {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? PsnID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? PsjIfFirst {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjRemark {get;set;}

           /// <summary>
           /// Desc:标签一
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjExtField1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjExtField2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? CreatorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ModifierID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? DeleterID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjGroup {get;set;}

           /// <summary>
           /// Desc:信息质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjQuality {get;set;}

           /// <summary>
           /// Desc:数据来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjSource {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? PsjPreExhID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? PsjRestDay {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.0
           /// Nullable:True
           /// </summary>           
           public double? PsjRestTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjVisibility {get;set;}

           /// <summary>
           /// Desc:参观卡号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjVisitorCard {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjAnswer {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComTradeKey1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComTradeKey2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComNameKey {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComCityKey {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComModelKey {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjSysState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:False
           /// </summary>           
           public DateTime PsjCreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfTreatKey {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfTreatRepeat {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfTreatCom {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfTelChk {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfFaxChk {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfMailChk {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfMobChk {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfAddChk {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjVoucherID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ComID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AtrID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjVoucherType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjLagCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjMsn {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjIfReceive {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjPostAddress {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjEAddress2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjEAddress3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjEAddress4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjSurName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjLastName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string PsjInviteCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool PsjIfPostCard {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjLanguage {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjAnswer1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjAnswer2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjAnswer3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjMainProduct {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjWorkNature {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjBsnNature {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PsjComScale {get;set;}

    }
}
