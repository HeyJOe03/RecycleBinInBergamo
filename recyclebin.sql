-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Mar 18, 2021 alle 11:29
-- Versione del server: 10.4.17-MariaDB
-- Versione PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `recyclebin`
--
CREATE DATABASE IF NOT EXISTS `recyclebin` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `recyclebin`;

-- --------------------------------------------------------

--
-- Struttura della tabella `bidoni`
--

CREATE TABLE `bidoni` (
  `ID` int(11) NOT NULL,
  `plastica` int(11) NOT NULL DEFAULT 100,
  `secco` int(11) NOT NULL DEFAULT 100
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `bidoni`
--

INSERT INTO `bidoni` (`ID`, `plastica`, `secco`) VALUES
(1, 96, 97),
(2, 88, 88),
(3, 100, 100),
(4, 47, 84),
(5, 100, 100);

-- --------------------------------------------------------

--
-- Struttura della tabella `utenti`
--

CREATE TABLE `utenti` (
  `CF` varchar(17) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `cognome` varchar(255) NOT NULL,
  `indirizzo` varchar(255) NOT NULL,
  `plastica` int(11) NOT NULL DEFAULT 0,
  `secco` int(11) NOT NULL DEFAULT 0,
  `MAXplastica` int(11) NOT NULL,
  `MAXsecco` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `utenti`
--

INSERT INTO `utenti` (`CF`, `nome`, `cognome`, `indirizzo`, `plastica`, `secco`, `MAXplastica`, `MAXsecco`) VALUES
('CRMGNN03A21H910M', 'Giovanni', 'Carminati', 'Via A. Locatello 84a', 93, 64, 1000, 1000),
('PLNPLNPLN1212AAH', 'Pietro', 'Plotta', 'Via Ronco 23', 60, 40, 4, 5),
('UDYKMR1203A437L', 'Uday', 'Kumar', 'Via Zanica 12', 0, 0, 120, 30),
('MRZARM04K32Y473F', 'Maurizio', 'Armati', 'Via dei lavori in corso', 0, 0, 240, 80),
('ANNBLZ04A21H910J', 'Anna', 'Belotti', 'Via San Giovanni 21A', 12, 12, 180, 50);

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `bidoni`
--
ALTER TABLE `bidoni`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `bidoni`
--
ALTER TABLE `bidoni`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
