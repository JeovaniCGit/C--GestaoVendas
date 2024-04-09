CREATE DATABASE  IF NOT EXISTS `bdistec` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bdistec`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: bdistec
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_clientes`
--

DROP TABLE IF EXISTS `tb_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nif` int DEFAULT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `profissao` varchar(30) DEFAULT NULL,
  `empresa` varchar(100) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `telem` varchar(20) DEFAULT NULL,
  `endereco` varchar(200) DEFAULT NULL,
  `pos` varchar(20) DEFAULT NULL,
  `freguesia` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `pais` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_clientes`
--

LOCK TABLES `tb_clientes` WRITE;
/*!40000 ALTER TABLE `tb_clientes` DISABLE KEYS */;
INSERT INTO `tb_clientes` VALUES (1,333666888,'fgegergerber','gguguyguyg','hghhgugug','abc@gmail.com','912555888','fgefger','3244-432','jhvgggy','liasboa','pt'),(2,123456789,'joao','professor','istec','abc@gmail.com','912345678','rua da bola','1234-567','lisboa','lisboa','Pt'),(3,987654322,'mario','pintor','pinturas','def@gmail.com','923145678','avenida lisboa','1243-654','lisboa','lisboa','Pt');
/*!40000 ALTER TABLE `tb_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_fornecedores`
--

DROP TABLE IF EXISTS `tb_fornecedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_fornecedores` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nif` int DEFAULT NULL,
  `empresa` varchar(100) DEFAULT NULL,
  `contacto` varchar(100) DEFAULT NULL,
  `funcao` varchar(30) DEFAULT NULL,
  `setor_empresa` varchar(10) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `telem` varchar(20) DEFAULT NULL,
  `endereco` varchar(200) DEFAULT NULL,
  `numero` int DEFAULT NULL,
  `pos` varchar(20) DEFAULT NULL,
  `freguesia` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_fornecedores`
--

LOCK TABLES `tb_fornecedores` WRITE;
/*!40000 ALTER TABLE `tb_fornecedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_fornecedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionarios`
--

DROP TABLE IF EXISTS `tb_funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_funcionarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `nif` int DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `senha` varchar(10) DEFAULT NULL,
  `funcao` varchar(100) DEFAULT NULL,
  `nivel_acesso` varchar(20) DEFAULT NULL,
  `telem` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionarios`
--

LOCK TABLES `tb_funcionarios` WRITE;
/*!40000 ALTER TABLE `tb_funcionarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_funcionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_itens_vendas`
--

DROP TABLE IF EXISTS `tb_itens_vendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_itens_vendas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `venda_id` int DEFAULT NULL,
  `produto_id` int DEFAULT NULL,
  `qtd` int DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `total_produto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `venda_id` (`venda_id`),
  KEY `produto_id` (`produto_id`),
  CONSTRAINT `tb_itens_vendas_ibfk_1` FOREIGN KEY (`venda_id`) REFERENCES `tb_vendas` (`id`),
  CONSTRAINT `tb_itens_vendas_ibfk_2` FOREIGN KEY (`produto_id`) REFERENCES `tb_produtos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_itens_vendas`
--

LOCK TABLES `tb_itens_vendas` WRITE;
/*!40000 ALTER TABLE `tb_itens_vendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_itens_vendas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_produtos`
--

DROP TABLE IF EXISTS `tb_produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_produtos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(100) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `qtd_armazem` int DEFAULT NULL,
  `fornecedor_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fornecedor_id` (`fornecedor_id`),
  CONSTRAINT `tb_produtos_ibfk_1` FOREIGN KEY (`fornecedor_id`) REFERENCES `tb_fornecedores` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_produtos`
--

LOCK TABLES `tb_produtos` WRITE;
/*!40000 ALTER TABLE `tb_produtos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_vendas`
--

DROP TABLE IF EXISTS `tb_vendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_vendas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cliente_id` int DEFAULT NULL,
  `data_venda` datetime DEFAULT NULL,
  `total_venda` decimal(10,2) DEFAULT NULL,
  `observacoes` text,
  PRIMARY KEY (`id`),
  KEY `cliente_id` (`cliente_id`),
  CONSTRAINT `tb_vendas_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `tb_clientes` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_vendas`
--

LOCK TABLES `tb_vendas` WRITE;
/*!40000 ALTER TABLE `tb_vendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_vendas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bdistec'
--

--
-- Dumping routines for database 'bdistec'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-10 22:04:43
