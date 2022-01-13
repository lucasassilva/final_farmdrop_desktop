-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.31-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para farmdrop
CREATE DATABASE IF NOT EXISTS `farmdrop` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `farmdrop`;

-- Copiando estrutura para tabela farmdrop.entradasaidafuncionarios
CREATE TABLE IF NOT EXISTS `entradasaidafuncionarios` (
  `Funcionario` varchar(150) NOT NULL,
  `Data_de_Entrada_saida` varchar(150) NOT NULL,
  `EntradaSaida` varchar(150) NOT NULL,
  `Horario` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela farmdrop.entradasaidafuncionarios: ~76 rows (aproximadamente)
DELETE FROM `entradasaidafuncionarios`;
/*!40000 ALTER TABLE `entradasaidafuncionarios` DISABLE KEYS */;
INSERT INTO `entradasaidafuncionarios` (`Funcionario`, `Data_de_Entrada_saida`, `EntradaSaida`, `Horario`) VALUES
	('admin', '06/05/2018', 'Entrou', '22:09:36'),
	('admin', '06/05/2018', 'Entrou', '22:09:57'),
	('admin', '06/05/2018', 'Entrou', '22:11:07'),
	('admin', '06/05/2018', 'Entrou', '22:29:07'),
	('admin', '06/05/2018', 'Entrou', '22:32:51'),
	('admin', '06/05/2018', 'Entrou', '22:33:46'),
	('admin', '06/05/2018', 'Entrou', '22:35:49'),
	('admin', '17/05/2018', 'Entrou', '13:39:38'),
	('admin', '17/05/2018', 'Entrou', '13:50:20'),
	('admin', '17/05/2018', 'Entrou', '13:58:55'),
	('admin', '17/05/2018', 'Entrou', '14:11:20'),
	('admin', '17/05/2018', 'Entrou', '14:16:42'),
	('admin', '17/05/2018', 'Entrou', '14:17:41'),
	('admin', '17/05/2018', 'Entrou', '14:19:30'),
	('admin', '17/05/2018', 'Entrou', '14:22:12'),
	('admin', '17/05/2018', 'Entrou', '14:22:49'),
	('admin', '17/05/2018', 'Entrou', '14:23:20'),
	('admin', '17/05/2018', 'Entrou', '14:26:52'),
	('admin', '17/05/2018', 'Entrou', '14:30:59'),
	('admin', '17/05/2018', 'Entrou', '14:31:25'),
	('admin', '17/05/2018', 'Entrou', '14:33:11'),
	('admin', '17/05/2018', 'Entrou', '14:33:50'),
	('admin', '17/05/2018', 'Entrou', '14:37:57'),
	('admin', '17/05/2018', 'Entrou', '14:45:57'),
	('admin', '17/05/2018', 'Entrou', '15:21:43'),
	('admin', '17/05/2018', 'Entrou', '15:22:33'),
	('admin', '18/05/2018', 'Entrou', '18:44:33'),
	('admin', '18/05/2018', 'Entrou', '18:47:51'),
	('admin', '18/05/2018', 'Entrou', '20:20:22'),
	('admin', '18/05/2018', 'Entrou', '20:32:39'),
	('admin', '18/05/2018', 'Entrou', '20:35:26'),
	('admin', '18/05/2018', 'Entrou', '20:36:51'),
	('admin', '18/05/2018', 'Entrou', '20:46:21'),
	('admin', '18/05/2018', 'Entrou', '20:48:29'),
	('admin', '18/05/2018', 'Entrou', '20:53:33'),
	('admin', '18/05/2018', 'Entrou', '20:59:40'),
	('admin', '18/05/2018', 'Entrou', '20:59:56'),
	('admin', '18/05/2018', 'Entrou', '21:00:32'),
	('admin', '18/05/2018', 'Entrou', '22:25:44'),
	('admin', '18/05/2018', 'Entrou', '22:26:58'),
	('admin', '18/05/2018', 'Entrou', '22:31:11'),
	('admin', '18/05/2018', 'Entrou', '22:32:18'),
	('admin', '18/05/2018', 'Entrou', '22:33:18'),
	('admin', '18/05/2018', 'Entrou', '22:34:26'),
	('admin', '18/05/2018', 'Entrou', '22:36:48'),
	('admin', '18/05/2018', 'Entrou', '22:38:08'),
	('admin', '18/05/2018', 'Entrou', '22:39:47'),
	('admin', '18/05/2018', 'Entrou', '22:41:03'),
	('admin', '18/05/2018', 'Entrou', '22:48:27'),
	('admin', '18/05/2018', 'Entrou', '22:51:45'),
	('admin', '19/05/2018', 'Entrou', '17:41:40'),
	('admin', '19/05/2018', 'Entrou', '17:42:00'),
	('admin', '19/05/2018', 'Entrou', '17:42:46'),
	('admin', '19/05/2018', 'Entrou', '17:48:37'),
	('admin', '19/05/2018', 'Entrou', '17:54:48'),
	('admin', '25/05/2018', 'Entrou', '20:55:05'),
	('admin', '06/06/2018', 'Entrou', '13:28:47'),
	('admin', '06/06/2018', 'Entrou', '13:47:55'),
	('admin', '06/06/2018', 'Entrou', '14:09:50'),
	('admin', '06/06/2018', 'Entrou', '14:12:00'),
	('admin', '06/06/2018', 'Entrou', '14:12:38'),
	('admin', '06/06/2018', 'Entrou', '14:25:29'),
	('admin', '06/06/2018', 'Entrou', '14:27:00'),
	('admin', '06/06/2018', 'Entrou', '14:28:38'),
	('admin', '06/06/2018', 'Entrou', '14:30:14'),
	('admin', '06/06/2018', 'Entrou', '14:31:31'),
	('admin', '06/06/2018', 'Entrou', '14:32:29'),
	('admin', '06/06/2018', 'Entrou', '14:38:54'),
	('admin', '06/06/2018', 'Entrou', '14:45:53'),
	('admin', '06/06/2018', 'Entrou', '16:17:16'),
	('admin', '06/06/2018', 'Entrou', '16:38:17'),
	('joao', '06/06/2018', 'Entrou', '17:04:39'),
	('admin', '06/06/2018', 'Entrou', '17:10:15'),
	('joao', '06/06/2018', 'Entrou', '20:06:12'),
	('admin', '06/06/2018', 'Entrou', '20:08:16'),
	('joao', '06/06/2018', 'Entrou', '20:08:33');
/*!40000 ALTER TABLE `entradasaidafuncionarios` ENABLE KEYS */;

-- Copiando estrutura para tabela farmdrop.entradasaidaremedios
CREATE TABLE IF NOT EXISTS `entradasaidaremedios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome_remedio` varchar(150) NOT NULL,
  `quantidade` varchar(10) NOT NULL,
  `data_entrada_saida` varchar(20) NOT NULL,
  `EntradaSaida` varchar(25) NOT NULL,
  `Local` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela farmdrop.entradasaidaremedios: ~5 rows (aproximadamente)
DELETE FROM `entradasaidaremedios`;
/*!40000 ALTER TABLE `entradasaidaremedios` DISABLE KEYS */;
INSERT INTO `entradasaidaremedios` (`id`, `nome_remedio`, `quantidade`, `data_entrada_saida`, `EntradaSaida`, `Local`) VALUES
	(1, '123', '123', '19/05/2018', 'Entrou', 'CILLOS'),
	(2, 'losartana 40 miligramas', '40', '19/05/2018', 'Saiu', 'MATHIENSEN'),
	(3, 'losartana 40 miligramas', '40', '19/05/2018', 'Entrou', 'MATHIENSEN'),
	(4, 'dipirona', '21', '06/06/2018', 'Entrou', 'MATHIENSEN'),
	(5, 'losartana 40 miligramas', '2', '06/06/2018', 'Saiu', 'MATHIENSEN');
/*!40000 ALTER TABLE `entradasaidaremedios` ENABLE KEYS */;

-- Copiando estrutura para tabela farmdrop.funcionarios
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `P_nome` varchar(150) NOT NULL,
  `idade` int(11) NOT NULL,
  `Email` varchar(150) NOT NULL,
  `Senha` varchar(150) NOT NULL,
  `Tipo` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela farmdrop.funcionarios: ~2 rows (aproximadamente)
DELETE FROM `funcionarios`;
/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
INSERT INTO `funcionarios` (`id`, `P_nome`, `idade`, `Email`, `Senha`, `Tipo`) VALUES
	(1, 'admin', 21, 'admin', 'admin', 'Administrador'),
	(3, 'joao', 21, 'joao', '123', 'Atendente');
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;

-- Copiando estrutura para tabela farmdrop.tabelasite
CREATE TABLE IF NOT EXISTS `tabelasite` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome_remedio` varchar(150) DEFAULT NULL,
  `quantidade` int(11) NOT NULL,
  `obs` varchar(150) DEFAULT NULL,
  `data_entrada` varchar(150) DEFAULT NULL,
  `Local` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela farmdrop.tabelasite: ~11 rows (aproximadamente)
DELETE FROM `tabelasite`;
/*!40000 ALTER TABLE `tabelasite` DISABLE KEYS */;
INSERT INTO `tabelasite` (`id`, `nome_remedio`, `quantidade`, `obs`, `data_entrada`, `Local`) VALUES
	(3, 'gadernal', 3, '', '06/05/2018', 'CARIOBINHA'),
	(4, 'dipirona em gotas', 8, '', '06/05/2018', 'PARQUE GRAMADO'),
	(5, 'dipirona monoidratada', 41, '', '06/05/2018', 'SÃO LUIZ'),
	(6, 'nimesulida', 33, '', '06/05/2018', 'SÃO DOMINGOS'),
	(7, 'anti-deprecivo', 88, '', '06/05/2018', 'SÃO JOSÉ'),
	(9, 'canabidiol', 54, '', '06/05/2018', 'CILLOS'),
	(11, 'losartana 40 miligramas', 1, '', '18/05/2018', 'MATHIENSEN'),
	(12, '123', 123, '123', '19/05/2018', 'CILLOS'),
	(13, '123', 123, '123', '19/05/2018', 'CILLOS'),
	(14, '123', 123, '123', '19/05/2018', 'CILLOS'),
	(15, 'dipirona', 21, '', '06/06/2018', 'MATHIENSEN');
/*!40000 ALTER TABLE `tabelasite` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
