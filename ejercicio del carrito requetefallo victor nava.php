<?php
$catalogo = 
["nombre"   => "harina", "precio" => 10, "stock"     => 30]; 
[ "nombre"   => "jugo", "precio" => 8, "stock"     => 20]; 
["nombre"   => "queso", "precio" => 15, "stock"     => 10];

function agregar_producto(&$catalogo, $nombre, $precio, $stock) {
    $catalogo[] = ["nombre" => $nombre, "precio" => $precio, "stock" => $stock];
}
function buscar_producto($catalogo, $nombre_buscando) {
    foreach ($catalogo as $producto) {
        if (strtolower($producto["nombre"]) === strtolower($nombre_buscado)) {
    }
}