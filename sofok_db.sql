-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2022 at 07:11 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sofok_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account`
--

CREATE TABLE `tbl_account` (
  `acc_id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `log_as` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_account`
--

INSERT INTO `tbl_account` (`acc_id`, `username`, `password`, `log_as`, `status`) VALUES
(63, 'admin', 'T+4Ai6O3CR0kJYxCgXy2jA==', 'Administrator', 'active'),
(98, 'tuprio@gmail.com', 'V02zy9YLAaJxk3au/LqxGw==', 'Merchant', 'active'),
(99, 'asd@gmail.com', 'Y+ZeQ74DLebrzzB+ogmTLg==', 'Merchant', 'active'),
(101, 'tuprio111@gmail.com', 'V02zy9YLAaJxk3au/LqxGw==', 'Merchant', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `admin_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `birthdate` date NOT NULL,
  `address` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `contact` bigint(20) NOT NULL,
  `acc_id` int(11) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`admin_id`, `name`, `birthdate`, `address`, `gender`, `contact`, `acc_id`, `status`) VALUES
(17, 'Administrator', '1989-06-15', 'Tuprio Residences 2', 'Male', 95652131, 63, '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_costumer`
--

CREATE TABLE `tbl_costumer` (
  `costumer_id` int(11) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_costumer`
--

INSERT INTO `tbl_costumer` (`costumer_id`, `date`) VALUES
(32, '2022-05-13');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_merchant`
--

CREATE TABLE `tbl_merchant` (
  `merchant_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `birthdate` date DEFAULT current_timestamp(),
  `marital_status` varchar(255) DEFAULT NULL,
  `gender` varchar(255) DEFAULT NULL,
  `contact_no` bigint(20) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `merchant_store` varchar(255) DEFAULT NULL,
  `profile_img` varchar(255) DEFAULT NULL,
  `gcash_img` varchar(255) NOT NULL,
  `login_status` int(11) NOT NULL,
  `acc_id` int(11) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_merchant`
--

INSERT INTO `tbl_merchant` (`merchant_id`, `name`, `birthdate`, `marital_status`, `gender`, `contact_no`, `address`, `merchant_store`, `profile_img`, `gcash_img`, `login_status`, `acc_id`, `status`) VALUES
(60, 'Rudy Lee Tuprio', '1989-11-24', 'Single', 'Male', 9563570387, '47 Macapagal St. Brgy Pasong Tamo Q.C', 'TupsiLogan', 'none', 'test.jpg', 0, 101, '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_orders`
--

CREATE TABLE `tbl_orders` (
  `order_id` int(11) NOT NULL,
  `item` varchar(255) NOT NULL,
  `qty` int(11) NOT NULL,
  `cost` double NOT NULL,
  `store` varchar(255) NOT NULL,
  `prod_id` int(11) NOT NULL,
  `order_action` varchar(255) NOT NULL,
  `payment` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `costumer_id` int(11) NOT NULL,
  `merchant_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_orders`
--

INSERT INTO `tbl_orders` (`order_id`, `item`, `qty`, `cost`, `store`, `prod_id`, `order_action`, `payment`, `status`, `costumer_id`, `merchant_id`) VALUES
(42, 'Cheesy Hotdog Sandwich', 1, 30, 'TupsiLogan', 127, 'Dine Out', 'gcash', 'pending', 32, 60),
(43, 'Hotdog Sandwich', 1, 20, 'TupsiLogan', 128, 'Dine Out', 'gcash', 'pending', 32, 60),
(44, 'Porkchop Silog', 1, 35, 'TupsiLogan', 123, 'Dine Out', 'gcash', 'pending', 32, 60),
(45, 'Bottled Water', 1, 10, 'TupsiLogan', 125, 'Dine Out', 'gcash', 'pending', 32, 60),
(46, 'Hotsilog ', 1, 35, 'TupsiLogan', 122, 'Dine Out', 'gcash', 'pending', 32, 60);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_products`
--

CREATE TABLE `tbl_products` (
  `prod_id` int(11) NOT NULL,
  `prod_name` varchar(255) NOT NULL,
  `product_category` varchar(255) NOT NULL,
  `prod_price` double NOT NULL,
  `merchant_id` int(11) NOT NULL,
  `product_icon` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_products`
--

INSERT INTO `tbl_products` (`prod_id`, `prod_name`, `product_category`, `prod_price`, `merchant_id`, `product_icon`, `status`) VALUES
(121, 'Bacon Silog', 'Meal', 55, 60, 'Bacon Silog - Php 55.00.png', ''),
(122, 'Hotsilog ', 'Meal', 35, 60, 'Hotsilog - Php 35.00.png', ''),
(123, 'Porkchop Silog', 'Meal', 35, 60, 'Porkchop Silog - Php 55.00.png', ''),
(125, 'Bottled Water', 'Drink', 10, 60, 'Bottled Water - Php 10.00.png', ''),
(126, 'Bottled Royal', 'Drink', 15, 60, 'Bottled Royal - Php 15.00.png', ''),
(127, 'Cheesy Hotdog Sandwich', 'Burger', 30, 60, 'Cheesy Hotdog Sandwich - Php 30.00.png', ''),
(128, 'Hotdog Sandwich', 'Burger', 20, 60, 'Hotdog Sandwich - Php 25.00.png', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rent`
--

CREATE TABLE `tbl_rent` (
  `rent_id` int(11) NOT NULL,
  `merchant_id` int(11) NOT NULL,
  `monthy_rent` double NOT NULL,
  `rent_recieve` date NOT NULL DEFAULT current_timestamp(),
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_rent`
--

INSERT INTO `tbl_rent` (`rent_id`, `merchant_id`, `monthy_rent`, `rent_recieve`, `status`) VALUES
(1, 0, 3500, '2022-05-13', 'paid'),
(2, 0, 3500, '2022-05-13', 'paid'),
(3, 60, 3500, '2022-05-13', 'paid');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_account`
--
ALTER TABLE `tbl_account`
  ADD PRIMARY KEY (`acc_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`admin_id`),
  ADD KEY `acc_id` (`acc_id`);

--
-- Indexes for table `tbl_costumer`
--
ALTER TABLE `tbl_costumer`
  ADD PRIMARY KEY (`costumer_id`);

--
-- Indexes for table `tbl_merchant`
--
ALTER TABLE `tbl_merchant`
  ADD PRIMARY KEY (`merchant_id`),
  ADD KEY `acc_id` (`acc_id`);

--
-- Indexes for table `tbl_orders`
--
ALTER TABLE `tbl_orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `prod_id` (`prod_id`),
  ADD KEY `customer_id` (`costumer_id`);

--
-- Indexes for table `tbl_products`
--
ALTER TABLE `tbl_products`
  ADD PRIMARY KEY (`prod_id`),
  ADD KEY `merchant_id` (`merchant_id`);

--
-- Indexes for table `tbl_rent`
--
ALTER TABLE `tbl_rent`
  ADD PRIMARY KEY (`rent_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_account`
--
ALTER TABLE `tbl_account`
  MODIFY `acc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=102;

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tbl_costumer`
--
ALTER TABLE `tbl_costumer`
  MODIFY `costumer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `tbl_merchant`
--
ALTER TABLE `tbl_merchant`
  MODIFY `merchant_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT for table `tbl_orders`
--
ALTER TABLE `tbl_orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `tbl_products`
--
ALTER TABLE `tbl_products`
  MODIFY `prod_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=129;

--
-- AUTO_INCREMENT for table `tbl_rent`
--
ALTER TABLE `tbl_rent`
  MODIFY `rent_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD CONSTRAINT `tbl_admin_ibfk_1` FOREIGN KEY (`acc_id`) REFERENCES `tbl_account` (`acc_id`);

--
-- Constraints for table `tbl_merchant`
--
ALTER TABLE `tbl_merchant`
  ADD CONSTRAINT `tbl_merchant_ibfk_1` FOREIGN KEY (`acc_id`) REFERENCES `tbl_account` (`acc_id`);

--
-- Constraints for table `tbl_orders`
--
ALTER TABLE `tbl_orders`
  ADD CONSTRAINT `tbl_orders_ibfk_1` FOREIGN KEY (`prod_id`) REFERENCES `tbl_products` (`prod_id`),
  ADD CONSTRAINT `tbl_orders_ibfk_2` FOREIGN KEY (`costumer_id`) REFERENCES `tbl_costumer` (`costumer_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
