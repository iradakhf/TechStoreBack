$(document).ready(() => {

    $(".addtobasket").click(function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(response => 
             response.text()
            ).then(data => {
                $("#headerCart").html(data)

            }
            )
    })
   
    $(document).on('click', '#closeIconforCartProduct', function (e) { 
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(response => 
                 response.text()
            ).then(data => {
                $("#headerCart").html(data);
            })
       

     })

})
