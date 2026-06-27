![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/logo.png)

<h4 align="center">
Enterprise Data Platform integrating ERP, Data Engineering,
Business Intelligence, Machine Learning, and Web Applications
</h4>

<p align="center">
  <a href="https://app.powerbi.com/view?r=eyJrIjoiNjA2NTFhYTgtNmI2Zi00ZTlkLTkwYjQtYTI4MzE5MDBjNDNjIiwidCI6IjJiYjZlNWJjLWMxMDktNDdmYi05NDMzLWMxYzZmNGZhMzNmZiIsImMiOjl9">
    <img src="https://img.shields.io/badge/Live_Dashboard-Power_BI-F2C811?style=for-the-badge&logo=powerbi&logoColor=black">
  </a>
</p>

# 🧰 Tools & Technologies
[![Odoo](https://img.shields.io/badge/Odoo-714B67?style=for-the-badge&logo=odoo&logoColor=white)]()
[![Databricks](https://img.shields.io/badge/Databricks-FF3621?style=for-the-badge&logo=databricks&logoColor=white)]()
[![Apache Spark](https://img.shields.io/badge/Apache_Spark-E25A1C?style=for-the-badge&logo=apachespark&logoColor=white)]()
[![Delta Lake](https://img.shields.io/badge/Delta_Lake-00ADD8?style=for-the-badge)]()
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)]()
[![Lakeflow](https://img.shields.io/badge/Lakeflow_Jobs-FF3621?style=for-the-badge)]()
[![Databricks Asset Bundles](https://img.shields.io/badge/Databricks_Asset_Bundles-FF3621?style=for-the-badge&logo=databricks&logoColor=white)]()
[![RPC API](https://img.shields.io/badge/RPC_API-009688?style=for-the-badge)]()
[![ODBC Driver](https://img.shields.io/badge/ODBC_Driver-Databricks-FF3621?style=for-the-badge&logo=databricks&logoColor=white)]()
[![Power BI](https://img.shields.io/badge/Power_BI-F2C811?style=for-the-badge&logo=powerbi&logoColor=black)]()
[![DAX](https://img.shields.io/badge/DAX-217346?style=for-the-badge)]()
[![Python](https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white)]()
[![Scikit-Learn](https://img.shields.io/badge/scikit--learn-F7931E?style=for-the-badge&logo=scikitlearn&logoColor=white)]()
[![MLflow](https://img.shields.io/badge/MLflow-0194E2?style=for-the-badge&logo=mlflow&logoColor=white)]()
[![ASP.NET MVC](https://img.shields.io/badge/ASP.NET_MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)]()
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)]()

# 📌 Project Overview
Smart Odoo is an enterprise analytics platform that integrates ERP operations, data engineering pipelines, business intelligence, machine learning, and web technologies into a unified decision-support system.

The platform extracts operational data from Odoo ERP, processes and transforms the data through Databricks and Delta Lake pipelines, builds analytical data marts, and delivers interactive dashboards and predictive insights.
ط
## ✅ Project Highlights

✅ 29+ Dashboard Pages

✅ 250+ Business KPIs

✅ 6 Domain-Oriented Data Marts

✅ 1 Enterprise Semantic Model

✅ Multiple Automated ETL Pipelines

✅ 5 Machine Learning Models

✅ ASP.NET MVC Web Application

✅ Odoo ERP Integration

✅ Medallion Architecture

✅ Databricks Data Platform

# 🎯 Project Objectives

- Build an end-to-end enterprise analytics platform.
- Transform ERP operational data into analytical insights.
- Design scalable data engineering pipelines.
- Develop business intelligence solutions for decision makers.
- Apply machine learning techniques for predictive analytics.
- Integrate operational and analytical systems into one platform.

# 🏢 Business Domains

The platform provides analytical and operational capabilities across the following business domains:

- Sales Management
- Procurement & Purchasing
- Inventory Management
- Financial & Invoice Operations
- Human Resources
- Customer Relationship Management (CRM)

# Challenges

- Handling large ERP transactional datasets.
- Designing scalable ETL pipelines.
- Managing cross-domain relationships.
- Building a unified semantic model.
- Creating reusable analytical data marts.
- Ensuring secure access and credential management.
   
# Overall System Architecture
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/FullArchieture.png)

# Data Engineering

## Data Engineering Objectives

The data engineering layer was designed to:

- Centralize ERP data.
- Ensure data quality.
- Build scalable ETL pipelines.
- Support analytical workloads.
- Deliver business-ready datasets.

## Data Engineering Architecture
The data engineering layer serves as the core foundation of Smart Odoo.

## Medallion Architecture (Analytics Server)
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/data_architeture.png)

## Components
- Odoo ERP Data Sources
- RPC API Integration
- Databricks Workspaces
- Apache Spark Processing
- Delta Lake Storage
- Lakeflow Job Orchestration
- Databricks Asset Bundles

---

## Galaxy Schema
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/OLAP_Dark.png)

---

## Pipeline Stages

The ETL pipelines extract data from Odoo ERP through RPC APIs,
validate the incoming records, transform them using Spark,
and store the final analytical datasets in Delta Lake.

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/Master_job.png)
- Data Extraction
- Data Validation
- Data Transformation
- Analytical Serving
  
---

## Security and Access Control
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/secrets.png)

---


# Business Intelligence

The business intelligence layer transforms analytical datasets
into actionable insights through interactive dashboards,
semantic models, DAX calculations, and executive KPIs.

The dashboards support operational, tactical, and strategic decisions.

## Semantic Model
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/Semantic_Model.png)

---

## Domain-Oriented Data Marts

- ### *Sales Mart*
  
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/Data_Marts/Sales_Mart.png)

- ### *Purchase Mart*
  
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/Data_Marts/Purchase_Mart.png)

- ### *Inventory Mart*
  
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/Data_Marts/Inventory_Mart.png)

- ### *Invoice Mart*
  
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/Data_Marts/Invoice_Mart.png)

- ### *CRM Mart*
  
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/Data_Marts/Crm_Mart.png)

- ### *HR Mart*
  
![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/Data_Marts/Hr_Mart.png)

---

## Dashboards

### *Revenue Analytics*

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Revenue.png)

- Revenue Tracking
- Conversion Analysis
- Opportunity Analysis
- Growth Monitoring

### *Customer Analytics*

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Revenue_Customer.png)

- Customer Behavior
- Repeat Customers
- Average Order Value
- Product Contribution

### *Procurement Analytics*

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Purchase.png)

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Purchase_Product.png)

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Purchase_Supplier.png)

- Supplier Performance
- Purchase Orders
- Spend Analysis

### *Inventory Analytics*

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Inventory.png)

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Inventory_Movement.png)

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/Warehouse.png)

- Stock Monitoring
- Inventory Valuation
- Warehouse Analysis

### *HR Analytics*

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/analytics/PowerBI_Screens/HR.png)

---

## Dashboard Features

- Drill Through
- Cross Filtering
- Dynamic Measures
- Field Parameters
- KPI Monitoring
- Time Intelligence
- Comparative Analysis

---

## Key Performance Indicators

We have created more than 250 metrics (key performance indicators) across all six domains

![](https://github.com/OmarAhmedWahby/Smart_Odoo/blob/main/docs/Screenshots/Measure_Tables.png)

---

# Machine Learning
  
The machine learning layer supports predictive analytics

Features:
- Predictive Models
- Forecasting
- Pattern Detection
- Business Recommendations 

---

# Web Application

The web application layer provides operational access.

Technologies:
- ASP.NET MVC
- C#
- Odoo Integration
- Authentication
- Role Management

---

# 👨‍💻Team Members

- ### Omar Ahmed Wahby  
- [LinkedIn](https://www.linkedin.com/in/omarwahby)  
- [GitHub](https://github.com/OmarAhmedWahby)
