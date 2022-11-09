
$(document).ready(function () {

    $('.show-product-modal').click(function (e) {
        e.preventDefault();

        var id = $(this).attr("data-id");

        fetch('https://localhost:44308/home/getbook/' + id)
            .then(response => response.text())
            .then(data => {
                $(".product-details-modal").html(data)
            });

        $("#quickModal").modal("show")

    })


})