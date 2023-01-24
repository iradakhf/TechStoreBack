$(document).ready(() => {

    $(".addtobasket").click(function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(response => {
            return response.text()
            }).then(data => {
                $("#headerCart").html(data)

            }
            )
    })
   
    $("#closeIconforCartProduct").click(
        function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(response => {
                return response.text()
            }).then(data => {
                $("#headerCart").html(data);
            })
       

     })

})
