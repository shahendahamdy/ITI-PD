var xhr = new XMLHttpRequest(); //{open}
//1-open
xhr.open("GET", "rockbands.json");
//3-event
xhr.onreadystatechange = function () {
  if (xhr.readyState == 4) {
    if (xhr.status >= 200 && xhr.status < 300) {
      // console.log(JSON.parse(xhr.response)); //arr
      var data = JSON.parse(xhr.response);
      keys = Object.keys(data);
      values = Object.values(data);
      console.log(values[0]);
      for (var i = 0; i < data.length; i++) {
        console.log(values[0][i].name);
      }

      $("#band").change(function () {
        for (var i = 0; i < keys.length; i++) {
          var $el = $("#artist");
          if ($(this).val() === keys[i]) {
            console.log("1");
            $el.empty(); // remove old options
            $.each(values[i], function (key, value) {
              $el.append(
                $("<option></option>")
                  .attr("value", value.value)
                  .text(value.name)
              );
            });
          }
        }
      });
    }
  }
};
xhr.send();
