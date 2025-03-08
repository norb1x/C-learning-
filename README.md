# .NET Design Patterns Workshop
## 📁 Projects Overview

### 1. Bank Client Management System
**Pattern**: Singleton  
**Features**:
- Secure client data management
- Automatic ID generation
- Console-based CRUD operations
- Balance tracking in PLN

### 2. Temperature Monitoring System 
**Pattern**: Observer  
**Features**:
- Real-time temperature updates
- Multiple monitoring stations
- Color-coded console alerts
- Sensor data validation

### 3. Payment Gateway Integration
**Pattern**: Adapter  
**Features**:
- Currency conversion to cents
- Card data encryption
- Transaction status mapping
- Error handling for API failures

### 4. Secure Logger Implementation
**Pattern**: Singleton  
**Features**:
- Thread-safe logging
- Dual output (console + file)
- Timestamp formatting
- Exception prevention mechanisms

## 🔧 Unit Tests Specification

### Test Strategy
    // Act
    var result = adapter.ProcessPayment(details);

    // Assert
    Assert.True(result);
    Assert.Equal(10000, mockService.LastRequest.AmountCents);
}

### Key Test Cases
| Component | Test Case | Expected Result |
|-----------|-----------|-----------------|
| `BankManager` | AddClient_NullName | Throws ArgumentException |
| `TemperatureSensor` | NotifyObservers_EmptyList | No exceptions thrown |
| `PaymentAdapter` | InvalidCurrencyConversion | Returns ErrorCode 400 |
| `Logger` | ConcurrentWrites | Atomic file operations |

### Coverage Goals
1. **Boundary Testing**: Minimum 90% for core components
2. **Exception Handling**: 100% coverage on error paths
3. **Pattern Validation**: Verify singleton/observer behavior
4. **Performance**: <100ms per complex transaction test

## 🚀 Getting Started

## 📚 Learning Resources
- Implemented Patterns: Singleton, Observer, Adapter
- Core Concepts: Lazy Initialization, Type Conversion, API Security
- Best Practices: SOLID principles, DI Container usage

## 📄 License
MIT License - Free for educational and commercial use



This README:

Maintains Polish project context through naming

Provides English technical documentation

Includes test strategy with code examples

Follows standard OSS project structure

Contains quick-start instructions



