$(document).ready(() => {
    $("a.btn.btn-danger.btn-sm").click(() => {
        return confirm("Are you sure you want to delete this record?");
    });
});