-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 21, 2024 at 05:53 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `base_delizia`
--

-- --------------------------------------------------------

--
-- Table structure for table `clientes`
--

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `Direccion` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clientes`
--

INSERT INTO `clientes` (`Id`, `Nombre`, `Apellido`, `Telefono`, `Direccion`) VALUES
(10, 'Juan', 'Pérez', '091200001', 'Calle 1 1234, Calle 2'),
(11, 'Lucas', 'Viña', '091200002', 'Calle 1 2345, Calle 2'),
(12, 'Joe', 'Barreto', '333', 'MMMMM'),
(13, 'Joe', 'Barreto', '091234567', 'mmmmmmmmmmm');

-- --------------------------------------------------------

--
-- Table structure for table `funcionarios`
--

CREATE TABLE `funcionarios` (
  `Cedula` varchar(10) NOT NULL,
  `Rol` int(11) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(20) NOT NULL,
  `Correo` varchar(50) NOT NULL,
  `Contrasena` varchar(20) NOT NULL,
  `Direccion` varchar(20) NOT NULL,
  `Activo` enum('Si','No') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `funcionarios`
--

INSERT INTO `funcionarios` (`Cedula`, `Rol`, `Nombre`, `Apellido`, `Correo`, `Contrasena`, `Direccion`, `Activo`) VALUES
('1', 1, 'Testing', ' ', ' ', 'testing', ' ', 'Si'),
('2', 2, 'Testing', ' ', ' ', 'testing', ' ', 'Si'),
('3', 3, 'Testing', ' ', ' ', 'testing', ' ', 'Si'),
('4', 4, 'Testing', ' ', ' ', 'testing', ' ', 'Si');

-- --------------------------------------------------------

--
-- Table structure for table `funcionariospedidos`
--

CREATE TABLE `funcionariospedidos` (
  `Funcionario` varchar(10) NOT NULL,
  `Pedido` int(11) NOT NULL,
  `Hora` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `funcionariospedidos`
--

INSERT INTO `funcionariospedidos` (`Funcionario`, `Pedido`, `Hora`) VALUES
('1', 5, '0000-00-00'),
('1', 6, '0000-00-00'),
('1', 7, '0000-00-00'),
('1', 8, '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `funcionariostelefonos`
--

CREATE TABLE `funcionariostelefonos` (
  `Funcionario` varchar(10) NOT NULL,
  `Telefono` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `funcionariostelefonos`
--

INSERT INTO `funcionariostelefonos` (`Funcionario`, `Telefono`) VALUES
('1', '095000001'),
('2', '095000002'),
('3', '095000003'),
('4', '095000004');

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Funcionario` varchar(10) NOT NULL,
  `Equipo` varchar(20) NOT NULL,
  `Tipo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`Fecha`, `Hora`, `Funcionario`, `Equipo`, `Tipo`) VALUES
('0000-00-00', '10:30:00', '1', 'BXC270014209713', NULL),
('0001-01-01', '00:00:00', '1', 'BXC270014209713', NULL),
('0001-01-01', '12:00:00', '1', 'BXC270014209713', NULL),
('2024-11-17', '22:34:45', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:12:42', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:15:09', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:20:25', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:22:28', '2', 'BXC270014209713', NULL),
('2024-11-18', '00:23:17', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:52:18', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:53:21', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:55:20', '1', 'BXC270014209713', NULL),
('2024-11-18', '00:57:56', '1', 'BXC270014209713', NULL),
('2024-11-18', '01:02:52', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:52:56', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:55:44', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:56:36', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:58:16', '1', 'BXC270014209713', NULL),
('2024-11-18', '13:59:38', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:00:48', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:02:59', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:06:13', '1', 'BXC270014209713', NULL),
('2024-11-18', '14:11:22', '1', 'BXC270014209713', NULL),
('2024-11-18', '15:53:44', '1', 'BXC270014209713', NULL),
('2024-11-18', '16:09:45', '1', 'BXC270014209713', NULL),
('2024-11-19', '16:26:51', '1', 'DESKTOP-MK97VHN', NULL),
('2024-11-19', '18:59:23', '1', 'BXC270014209713', NULL),
('2024-11-19', '18:59:36', '2', 'BXC270014209713', NULL),
('2024-11-19', '18:59:43', '3', 'BXC270014209713', NULL),
('2024-11-19', '19:15:02', '1', 'BXC270014209713', NULL),
('2024-11-19', '19:21:22', '1', 'BXC270014209713', NULL),
('2024-11-19', '21:24:25', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:26:22', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:31:33', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:37:56', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:39:45', '4', 'BXC270014209713', NULL),
('2024-11-19', '21:41:58', '4', 'BXC270014209713', NULL),
('2024-11-19', '22:07:04', '4', 'BXC270014209713', NULL),
('2024-11-19', '22:33:49', '1', 'BXC270014209713', NULL),
('2024-11-19', '22:56:56', '1', 'BXC270014209713', NULL),
('2024-11-19', '22:57:50', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:00:27', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:03:06', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:04:21', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:33:02', '1', 'BXC270014209713', NULL),
('2024-11-19', '23:35:26', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:38:37', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:38:58', '1', 'BXC270014209713', NULL),
('2024-11-20', '15:39:53', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:55:27', '2', 'BXC270014209713', NULL),
('2024-11-20', '15:56:16', '1', 'BXC270014209713', NULL),
('2024-11-20', '18:14:44', '1', 'BXC270014209315', NULL),
('2024-11-20', '18:39:22', '1', 'BXC270014209713', NULL),
('2024-11-20', '18:40:14', '2', 'BXC270014209713', NULL),
('2024-11-20', '18:45:16', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:40:30', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:41:09', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:46:43', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:52:14', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:56:20', '2', 'BXC270014209713', NULL),
('2024-11-21', '00:57:31', '2', 'BXC270014209713', NULL),
('2024-11-21', '01:09:27', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:09:40', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:09:48', '2', 'BXC270014209713', NULL),
('2024-11-21', '01:11:02', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:11:10', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:21:06', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:21:14', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:48:12', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:48:52', '3', 'BXC270014209713', NULL),
('2024-11-21', '01:49:56', '3', 'BXC270014209713', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `pedidos`
--

CREATE TABLE `pedidos` (
  `Id` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Estado` int(11) NOT NULL,
  `Precio` double NOT NULL,
  `Cliente` int(11) NOT NULL,
  `Repartidor` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pedidos`
--

INSERT INTO `pedidos` (`Id`, `Fecha`, `Hora`, `Estado`, `Precio`, `Cliente`, `Repartidor`) VALUES
(5, '2024-11-19', '23:33:43', 3, 640, 10, '3'),
(6, '2024-11-20', '15:39:48', 3, 1070, 11, '3'),
(7, '2024-11-20', '18:15:23', 3, 1000, 12, '3'),
(8, '2024-11-20', '18:40:08', 3, 1070, 13, '3');

-- --------------------------------------------------------

--
-- Table structure for table `pedidosproductos`
--

CREATE TABLE `pedidosproductos` (
  `Pedido` int(11) NOT NULL,
  `Producto` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pedidosproductos`
--

INSERT INTO `pedidosproductos` (`Pedido`, `Producto`, `Cantidad`) VALUES
(5, 1, 1),
(5, 5, 1),
(5, 6, 2),
(6, 1, 1),
(6, 4, 1),
(6, 5, 2),
(7, 1, 2),
(7, 3, 1),
(8, 1, 1),
(8, 3, 1),
(8, 5, 2);

-- --------------------------------------------------------

--
-- Table structure for table `productos`
--

CREATE TABLE `productos` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Precio` double NOT NULL,
  `Tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `productos`
--

INSERT INTO `productos` (`Id`, `Nombre`, `Precio`, `Tipo`) VALUES
(1, 'Queso 30cm', 500, 1),
(2, 'Pepperoni 30cm', 500, 1),
(3, '4 Quesos 30cm', 500, 1),
(4, 'Hawaiana 30cm', 500, 1),
(5, 'Coca-Cola 500ml', 70, 2),
(6, 'Sprite 500ml', 70, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tickets`
--

CREATE TABLE `tickets` (
  `Id` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Pedido` int(11) NOT NULL,
  `Pago` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tickets`
--

INSERT INTO `tickets` (`Id`, `Fecha`, `Hora`, `Pedido`, `Pago`) VALUES
(1, '2024-11-19', '23:33:43', 5, 0),
(2, '2024-11-20', '15:39:48', 6, 0),
(3, '2024-11-20', '18:15:23', 7, 0),
(4, '2024-11-20', '18:40:08', 8, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`Cedula`);

--
-- Indexes for table `funcionariospedidos`
--
ALTER TABLE `funcionariospedidos`
  ADD PRIMARY KEY (`Funcionario`,`Pedido`),
  ADD KEY `Pedido` (`Pedido`);

--
-- Indexes for table `funcionariostelefonos`
--
ALTER TABLE `funcionariostelefonos`
  ADD PRIMARY KEY (`Funcionario`,`Telefono`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`Fecha`,`Hora`,`Funcionario`),
  ADD KEY `Funcionario` (`Funcionario`);

--
-- Indexes for table `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Cliente` (`Cliente`),
  ADD KEY `Repartidor` (`Repartidor`);

--
-- Indexes for table `pedidosproductos`
--
ALTER TABLE `pedidosproductos`
  ADD PRIMARY KEY (`Pedido`,`Producto`),
  ADD KEY `Producto` (`Producto`);

--
-- Indexes for table `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Pedido` (`Pedido`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `productos`
--
ALTER TABLE `productos`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tickets`
--
ALTER TABLE `tickets`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `funcionariospedidos`
--
ALTER TABLE `funcionariospedidos`
  ADD CONSTRAINT `funcionariospedidos_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`),
  ADD CONSTRAINT `funcionariospedidos_ibfk_2` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`);

--
-- Constraints for table `funcionariostelefonos`
--
ALTER TABLE `funcionariostelefonos`
  ADD CONSTRAINT `funcionariostelefonos_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`);

--
-- Constraints for table `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `logs_ibfk_1` FOREIGN KEY (`Funcionario`) REFERENCES `funcionarios` (`Cedula`);

--
-- Constraints for table `pedidos`
--
ALTER TABLE `pedidos`
  ADD CONSTRAINT `Repartidor` FOREIGN KEY (`Repartidor`) REFERENCES `funcionarios` (`Cedula`),
  ADD CONSTRAINT `pedidos_ibfk_1` FOREIGN KEY (`Cliente`) REFERENCES `clientes` (`Id`);

--
-- Constraints for table `pedidosproductos`
--
ALTER TABLE `pedidosproductos`
  ADD CONSTRAINT `pedidosproductos_ibfk_1` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`),
  ADD CONSTRAINT `pedidosproductos_ibfk_2` FOREIGN KEY (`Producto`) REFERENCES `productos` (`Id`);

--
-- Constraints for table `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`Pedido`) REFERENCES `pedidos` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
