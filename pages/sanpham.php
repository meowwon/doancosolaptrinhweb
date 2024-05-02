  <div>
      <?php
        if (isset($_GET['quanly'])) {
            $tam = $_GET['quanly'];
        } else {
            $tam = '';
        }
        if ($tam == "sachkinhte") {
            include("sanpham/sachkinhte.php");
        } elseif ($tam == 'sachnvanhoc') {
            include("sanpham/sachvanhoc.php");
        } elseif ($tam == 'cart') {
            include("giohang.php");
        } elseif ($tam == 'home') {
            include("sanpham/sachtong.php");
        } else {
            include("sanpham/sachtong.php");
        }

        ?>
  </div>