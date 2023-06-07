var tools = new function () {
    
    this.loader = {
        block: function () {
            $.blockUI({ message: '<h4><img alt="ajax_loader_gray_32.gif" src="data:image/gif;base64,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" /> Por favor espere...</h4>' });
        },
        unblock: function () {
            $.unblockUI();
        }
    };

    this.validate = {
        number: function (e) {
            var evt = (e) ? e : window.event;
            var charCode = (evt.keyCode) ? evt.keyCode : evt.which;
            if (charCode == 13) return true;
            if (charCode > 31 && (charCode < 48 || charCode > 57) && (e.keyCode < 96 || e.keyCode > 105)) {
                return false;
            }
            return true;
        }
    }

    this.format = {
        date: function (date) {
            return moment(date).format("DD/MM/YYYY");
        }
    }

};

function jsonServerResponse(url, data, beforeSend, success, error, complete) {
    JSOoptionalData = (typeof JSOoptionalData == "undefined") ? 'defaultValue' : JSOoptionalData
    var jqxhr = $.ajax({
        type: "GET",
        url: url,
        data: data,
        dataType: "json",
        cache: false,
        beforeSend: beforeSend,
        success: success,
        error: error,
        complete: complete
    });
}

function jsonServerPost(url, data, beforeSend, success, error, complete) {
    JSOoptionalData = (typeof JSOoptionalData == "undefined") ? 'defaultValue' : JSOoptionalData
    var jqxhr = $.ajax({
        type: "POST",
        url: url,
        data: data,
        dataType: "json",
        cache: false,
        beforeSend: beforeSend,
        success: success,
        error: error,
        complete: complete
    });
}