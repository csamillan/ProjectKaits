import { Button, Table } from "reactstrap"

const TableOrder = ({data}) => {

    return (
        <Table striped responsive>
            <thead>
                <tr>
                    <th> Id</th>
                    <th> Fecha</th>
                    <th> Cliente</th>
                    <th> Precio Total</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                {
                    (data.length < 1) ? (
                        <tr>
                            <td colSpan="5"> Sin Registros</td>
                        </tr>
                    ) : (
                        data.map((item) => (
                            <tr key={item.orderId}>
                                <td>{item.orderId}</td>
                                <td>{item.dateOrder}</td>
                                <td>{item.client.clientName}</td>
                                <td>{item.totalPrice}</td>
                                <td>
                                    <Button color="primary" size="sm" className="me-2">Ver Detalle</Button>
                                </td>
                            </tr>
                        ))
                    )
                }
            </tbody>
        </Table>
    )
}

export default TableOrder;