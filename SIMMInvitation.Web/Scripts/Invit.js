function LoginSubmit()
{
    var $AtrName = $("#AtrName").val();
    var $BthCode = $("#BthCode").val();
    if ($AtrName == "") {
        Tips.alert('参展公司名称不能为空！');
        return;
    }
    else if ($BthCode == "") {
        Tips.alert('展位号不能为空！');
        return;
    }
    else if ($AtrName == "" && $BthCode == "")
    {
        Tips.alert('参展公司名称、展位号不能为空！');
        return;
    }
    else {
        $.ajax({
            url: "/SIMMInvitation/Invitation/LoginSubmits",
            data: { 'AtrName': $AtrName, 'BthCode': $BthCode },
            cache: false,
            success: function (msg) {
                if (msg.IsSuccess) {
                    var AtrID = msg.ResultInfo;
                    //encodeURI
                    window.location.href = "/SIMMInvitation/ExhibitorMes/Index?AtrName={0}&BthCode={1}&AtrID={2}".ejq_format(escape($AtrName), escape($BthCode), escape(AtrID));
                } else {
                    Tips.alert(msg.ResultInfo);
                }
            },
            error: function (msg) {
                console.log(msg);
            }
        });
    }
}