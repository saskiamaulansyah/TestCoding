@Code
    ViewData("Title") = "Home Page"
End Code


<style>


    p.outset {
        border-bottom: 1px solid grey;
    }
</style>
<div class="row">
    <div class="col-md-12">
        <h2></h2>

        <p><a class="btn btn-default" onclick="test()">Tampilkan</a></p>
    </div>
    <div class="col-md-4" style="height:350px;width:350px;border:1px solid #ccc;font:16px/26px Georgia, Garamond, Serif;overflow:auto;">
        <h5>Peribahasa hari ini :</h5>

        Gajah mati meninggalkan gadingnya, macan mati meninggalkan belangnya, manusia mati meninggalkan namanya
        <div></div>
        <i style="font-size:10px">Posted: Thu Jan 01 2004 01:45:52 GMT+0700 (SE Asia Standard Time)</i>
        <p class="outset"></p>
        <h5>Peribahasa hari ini :</h5>

        Sejelek-jeleknya pemimpin pasti punya anak buah, sebaik-baiknya pemimpin pasti punya musuh
        <div></div>
        <i style="font-size:10px">Posted: Thu Jan 01 2004 01:45:53 GMT+0700 (SE Asia Standard Time)</i>
        <p class="outset"></p>
        <h5>Peribahasa hari ini :</h5>

        Bagai kerakap di atas batu, hidup segan mati tak mau
        <div></div>
        <i style="font-size:10px">Posted: Thu Jan 01 2004 01:45:54 GMT+0700 (SE Asia Standard Time)</i>
        <p class="outset"></p>
        <h5 id="satu"></h5>
        <p id="p1"></p>
        <div></div>
        <i id="i1"  style="font-size:10px"></i>
    </div>


</div>
<script>

    function test() {
        document.getElementById("satu").innerHTML = "Peribahasa hari ini :";
        document.getElementById("p1").innerHTML = "Bagai air diatas daun talas";
        document.getElementById("i1").innerHTML = "Posted: Thu Jan 01 2004 01:45:55 GMT+0700 (SE Asia Standard Time)";
    }
</script>
