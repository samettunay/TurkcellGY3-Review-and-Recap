$(document).ready(function () {

    $('.basket').on('click', function () {
        let id = $(this).data('id');
        $.ajax({
            url: '/Shopping/AddProduct/' + id,
            type: 'GET',
            success: function (data) {
                console.log(data)
                $('.toast-body').text(data.message);
                //const toastLiveExample = document.getElementById('liveToast');
                //const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample);
                //toastBootstrap.show();
                alertify.success(data.message);
                //location = location;

            },
            error: function (err) {
                console.log('hata', error);
            }
        });
    });
});