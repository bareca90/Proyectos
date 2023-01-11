<?php

    $serverName = "10.100.120.7";
    $connectionInfo = array( "Database"=>"SipeDes", "UID"=>"sa", "PWD"=>"84+-blaster32","CharacterSet"=>"UTF-8");
    $con = sqlsrv_connect($serverName, $connectionInfo);
    if(!$con) {     
        echo"Error al conectar a la base de datos"; 
        exit();               
    }
?>

<html>
    <head>
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css" integrity="sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm" crossorigin="anonymous">
        <link rel="stylesheet" href="css.css" type="text/css">
        <link rel="stylesheet" href="css-tabla1.css" type="text/css">
        <link rel="stylesheet" href="cards.css" type="text/css">
        <!--<link rel="stylesheet" href="csstitulos.css" type="text/css">-->
    </head>
    <div>
        <div class="contenedor_titulo">
            <div class="div_container_titulo">
                <img src="img/logopm.jpg">
            </div>
            <div class="contenido_titulo">
                <h2 class="titulo_principal">
                   <u>Datos Recepciòn </u> 
                </h2>
            </div>
        </div>
        <div id="container">
            <?php 
                $sql="
                        Select	Top 1	'AG#'+Convert(Varchar,PyAqNo) 'Aguaje'	,
                        Case
                            When	CONVERT(nvarchar(10), GETDATE(), 108)>'07:00'
                                And	CONVERT(nvarchar(10), GETDATE(), 108)<'19:00'
                            Then	'Día'
                            Else	'Noche'
                        End	 'Turno'													
                        From	PRPYAQ	With(NoLock)
                        Where	PyAqFecIni	<=  GETDATE()             
                        Order	By PyAqFecIni Desc";
                $result=sqlsrv_query($con,$sql);
                while($muestra=sqlsrv_fetch_array($result)){
                    $aguaje=$muestra['Aguaje'];
                    $turno=$muestra['Turno'];
                }
            ?>
            <div class="kpi-card orange">
                <span class="card-value">Fecha</span>
                <span class="card-text"><?php 
                        
                       //$Dateactual = $fechaactual->format('d/m/Y');
                        echo date('d/m/Y');
                        //echo $Dateactual;
                        
                        
                        ?> 
                </span>
                <i class="fas fa-calendar icon"></i>
            </div>
        
        
            <div class="kpi-card purple">
                <span class="card-value">Aguaje</span>
                <span class="card-text"><?php echo $aguaje?> </span>
                <i class="fas fa-moon icon"></i>
            </div>
            
           
            
            <div class="kpi-card red">
                <span class="card-value">Turno</span>
                <span class="card-text">
                    <?php 
                        echo $turno; 
                    ?>
                </span>
                <i class="fas fa-stopwatch icon"></i>
                
            </div>
        </div>
        <div class="titulo_tabla_dash">
            <h2>Detalle Guìas de Pesca</h2>
            
        </div>
        <table>
            <thead>
                <tr>
                    <th class="ancho_celdas_normales"> Fecha Llegada Planta </th>
                    <th class="ancho_celdas_normales"> # Ingreso</th>
                    <th class="ancho_celdas_normales"> # Guia</th>
                    <!-- <th class="ancho_celdas_normales"> Secuencia </th> -->
                    <th class="ancho_celdas_normales"> Proveedor </th>
                    <th class="ancho_celdas_normales"> # Pisc </th>
                    <th class="ancho_celdas_normales"> Orden Pesca </th>
                    <th class="ancho_celdas_normales"> Kilos </th>
                    <th class="ancho_celdas_normales"> Gramaje </th>
                    <th class="ancho_celdas_normales"> Tiempo Tratamiento </th>
                    <th class="ancho_celdas_normales"> Tiempo Max Trat. Inicial </th>
                    <th class="ancho_celdas_normales"> Tiempo Pesca </th>
                    <th class="ancho_celdas_normales"> Tiempo Esp. Recepciòn </th>
                    <th class="ancho_celdas_barra">  </th>

                    
                </tr>
            </thead>
            <tbody>
                <?php 
                    $sql="Select	Top 50 
                                    IngresoSeguridad			                                                    ,
                                    NoGuia						                                                    ,
                                    --Sec							                                                ,
                                    Proveedor					                                                    ,
                                    Piscina						                                                    ,
                                    OrdenPesca                                                                      ,
                                    FechaLLegadaPlanta			                                                    ,
                                    Kilos						                                                    ,
                                    [Gramaje Calidad] GramajeCalidad                                                ,
                                    TiempoTratamiento                                                               ,
                                    Convert(Char(8),Cast([Fecha maxima Tratamiento Inicial] As Time)) 'TiempoMax'   ,
                                    TiempoDePesca				                                                    ,
                                    TiempoEsperaRecepcionPlanta	                                                    ,
                                    Case 
                                        When	TiempoEsperaRecepcionPlanta	>='00:00'	And	TiempoEsperaRecepcionPlanta	<=	'04:59'
                                            Then	10 --Verde 
                                        When	TiempoEsperaRecepcionPlanta	>='05:00'	And	TiempoEsperaRecepcionPlanta	<=	'07:59'
                                            Then	20 --Amarillo
                                        When	TiempoEsperaRecepcionPlanta	>'08:00'
                                            Then	30	--Rojo
                                    End	'Indicador'
                            From Vsp_DatosRecepcion Where Tipo	='Saldo' 
                            Order By FechaLLegadaPlanta,IngresoSeguridad  ";
                    $result=sqlsrv_query($con,$sql);
                    while($mostrar=sqlsrv_fetch_array($result)){
                ?>

                <tr>
                    <td><?php echo $mostrar['FechaLLegadaPlanta']->format('d/m/Y') ?></td>
                    <td><?php echo $mostrar['IngresoSeguridad'] ?></td>
                    <td><?php $Date = $mostrar['NoGuia']; echo $Date; ?></td>
                    <td><?php echo $mostrar['Proveedor'] ?></td>
                    <td><?php echo $mostrar['Piscina'] ?></td>
                    <td><?php echo $mostrar['OrdenPesca'] ?></td>
                    <td><?php echo number_format($mostrar['Kilos'],2) ?></td>
                    <td><?php echo number_format($mostrar['GramajeCalidad'],2) ?></td>                    
                    <td><?php echo $mostrar['TiempoTratamiento'] ?></td>
                    <td><?php echo $mostrar['TiempoMax'] ?></td>
                    <td><?php echo $mostrar['TiempoDePesca'] ?></td>
                    <td><?php echo $mostrar['TiempoEsperaRecepcionPlanta'] ?></td>
                    
                    <td>
                        <?php 
                            $porcentaje = $mostrar['Indicador'];
                            if($porcentaje==10){
                                echo "
                                <div  class='btn btn-success btn-circle btn-circle-sm m-1'>
                                    
                                </div>
                                ";
                                /* <i class='fa fa-check'></i> */
                                

                            }
                            if($porcentaje==20){        
                                echo "
                                <div  class='btn btn-warning btn-circle btn-circle-sm m-1'>
                                </div>
                                
                                ";
                                /* <i class='fa fa-tags'></i> */
                                
                            }
                            if($porcentaje==30){        
                                echo "
                                <div  class='btn btn-danger btn-circle btn-circle-sm m-1'>
                                </div>";
                                /* <i class='fa fa-times'></i> */
                            }
                            
                        ?>
                        
                        
                    </td>


                    
                    
                </tr>
                <?php 
                }
                ?>


                <!--
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar" data-complete="70" style="width: 80%; opacity: 1;">
                                <hr class="completed-bar__dashed">
                                <i class="fas fa-truck-moving completed-bar__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-amarillo" data-complete="70" style="width: 50%; opacity: 1;">
                                <hr class="completed-bar-amarillo__dashed">
                                <i class="fas fa-truck-moving completed-bar-amarillo__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar" data-complete="70" style="width: 30%; opacity: 1;">
                                <hr class="completed-bar__dashed">
                                <i class="fas fa-truck-moving completed-bar__truck"></i>
                            </div>
                        </div>
                        
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-amarillo" data-complete="70" style="width: 60%; opacity: 1;">
                                <hr class="completed-bar-amarillo__dashed">
                                <i class="fas fa-truck-moving completed-bar-amarillo__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-rojo" data-complete="70" style="width: 0%; opacity: 1;">
                                <hr class="completed-bar-rojo__dashed">
                                <i class="fas fa-truck-moving completed-bar-rojo__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-rojo" data-complete="70" style="width: 90%; opacity: 1;">
                                <hr class="completed-bar-rojo__dashed">
                                <i class="fas fa-truck-moving completed-bar-rojo__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-rojo" data-complete="70" style="width: 5%; opacity: 1;">
                                <hr class="completed-bar-rojo__dashed">
                                <i class="fas fa-truck-moving completed-bar-rojo__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-rojo" data-complete="70" style="width: 5%; opacity: 1;">
                                <hr class="completed-bar-rojo__dashed">
                                <i class="fas fa-truck-moving completed-bar-rojo__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-rojo" data-complete="70" style="width: 5%; opacity: 1;">
                                <hr class="completed-bar-rojo__dashed">
                                <i class="fas fa-truck-moving completed-bar-rojo__truck"></i>
                            </div>
                        </div>
                        
                    </td>
                    
                    
                </tr>
                <tr>
                    <td> 22/04/2022 </td>
                    <td> 10852 </td>
                    <td> 10:20 </td>
                    <td> PescanoVa France </td>
                    <td> A_Bajana </td>
                    <td> 8 </td>
                    <td> Viernes </td>
                    <td> 2500/3000 </td>
                    <td>
                        <div class="progress-bar">
                            <div class="js-completed-bar completed-bar-rojo" data-complete="70" style="width: 5%; opacity: 1;">
                                <hr class="completed-bar-rojo__dashed">
                                <i class="fas fa-truck-moving completed-bar-rojo__truck"></i>
                            </div>
                        </div>
                        
                        
                        
                    </td>
                    
                    
                </tr>
                -->
            </tbody>
            
            
        </table>
        <!--
        <div class="progress-bar">
            <div class="js-completed-bar completed-bar-rojo" data-complete="70" style="width: 30%; opacity: 1;">
                <hr class="completed-bar-rojo__dashed">
                <i class="fas fa-truck-moving completed-bar-rojo__truck"></i>
            </div>
        </div>
        <div class="box box-down blue">
            <h2>Plan de Embarques Diarios</h2>
        </div>
        -->
    </div>
    <script type="text/javascript">
        const progress = document.querySelector(".js-completed-bar");
        if (progress) {
            progress.style.width = progress.getAttribute("data-complete") + "%";
            progress.style.opacity = 1;
        }
        //Función actualizar
        
        function actualizar(){location.reload(true);}
        //Función para actualizar cada 5 segundos(5000 milisegundos)
        setInterval("actualizar()",10000);
        
    </script>
    
</html>
