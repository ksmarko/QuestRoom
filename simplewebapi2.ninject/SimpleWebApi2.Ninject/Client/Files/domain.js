function GetAllQuests() {

    $.ajax({
        url: '/api/quests',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            WriteResponse(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function ShowModal(data) {

    var code = "";
    code += "<div class='modal-dialog' role='document'>";
    code += "<div class='modal-content'>";
    code += "<div class='modal-header'>";
    code += "<button type='button' class='close' data-dismiss='modal' aria-label='Close'><span aria-hidden='true'>&times;</span></button>";
    code += "<h4 class='modal-title' id='content'><strong>" + data.Name + "</strong></h4></div>";
    code += "<div class='modal-body'> <dl class='dl-horizontal'>";
    code += "<dt> PlayersLimit </dt> <dd>" + data.PlayersLimit + "</dd > <dt> Price </dt> <dd>" + data.Price + " </dd > ";
    code += "<dt> Duration </dt>  <dd> " + data.Duration + " </dd>  <dt> Description </dt> <dd> " + data.Description + " </dd>";
    code += "</dl> </div>";
    code += "<div class='modal-footer'> <button type='button' class='btn btn-success' data-dismiss='modal'>Close</button>";
    code += "</div> </div> </div>";

    $("#myModal").html(code);
    $("#myModal").modal();
}

// вывод полученных данных на экран
function WriteResponse(quests) {
    var strResult = "<table class=\"table\"";
    strResult += "<tr>";
    strResult += "<th>Quest name</th>";
    strResult += "<th>Duration</th>";
    strResult += "<th>Players limit</th>";
    strResult += "<th>Price</th>";
    strResult += "<th></th></tr>";
    $.each(quests, function (index, quest) {
        strResult += "<tr><td>" + quest.Id + "</td><td> " + quest.Name + "</td><td>" +
            quest.Duration + "</td><td>" + quest.PlayersLimit + "</td><td>" + quest.Price +
            "</td><td><a style='cursor: pointer' onclick='GetBook(" + quest.Id + ");' >Info</a> | " +
            " <a style='cursor: pointer' onclick='ShowReserv(" + quest.Id + ");' >Reserv</a></td > ";
    });
    strResult += "</table>";
    $("#tableBlock").html(strResult);

}

function GetBook(id) {
    $.ajax({
        url: '/api/quests/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            ShowModal(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function ShowReserv(id) {
    document.cookie = "QuestId=" + id;
    location.href = "reserv.html";
}

function LoadReservData() {
    var id = getCookie("QuestId");

    $.ajax({
        type: 'GET',
        url: "/api/quests/" + id,
        success: function (data) {
            $("#reserv-title").text("Reservation for " + data.Name);
        },
        fail: function (data) {
            alert(data);
        }
    });
}

function Reserv() {
    var id = getCookie("QuestId");

    var data = {
        QuestId: id,
        Date: $('#inp-date').val(),
        Time: $('#inp-time').val(),
        Code: $('#inp-code').val(),
    };

    $.ajax({
        type: 'POST',
        url: "/api/quests/reserv",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(data),
        success: function (data) {
            alert(data);
            location.href = 'index.html';
        },
        fail: function (data) {
            alert(data);
        }
    });
}

function getCookie(cookie_name) {
    var results = document.cookie.match('(^|;) ?' + cookie_name + '=([^;]*)(;|$)');

    if (results)
        return (unescape(results[2]));
    else
        return null;
}

function deleteCookie(name) {
    setCookie(name, "", {
        expires: -1
    })
}

function setCookie(name, value, options) {
    options = options || {};

    var expires = options.expires;

    if (typeof expires == "number" && expires) {
        var d = new Date();
        d.setTime(d.getTime() + expires * 1000);
        expires = options.expires = d;
    }
    if (expires && expires.toUTCString) {
        options.expires = expires.toUTCString();
    }

    value = encodeURIComponent(value);

    var updatedCookie = name + "=" + value;

    for (var propName in options) {
        updatedCookie += "; " + propName;
        var propValue = options[propName];
        if (propValue !== true) {
            updatedCookie += "=" + propValue;
        }
    }

    document.cookie = updatedCookie;
}